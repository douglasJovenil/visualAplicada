using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace ImagemMonocromatica
{
    public partial class MainForm : Form
    {
        private int MainFormPositionX, MainFormPositionY;
        private string CurrentPlayer, StandbyPlayer, IdPlayer, WinnerPlayer;
        private Connector ObjConnector;
        private Bitmap XImage, OImage;
        private bool MainMoveForm;
        private int SecondsToRestart;
        char OwnLetter;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Button[] Buttons = { MainButton11, MainButton12, MainButton13,
                                 MainButton21, MainButton22, MainButton23,
                                 MainButton31, MainButton32, MainButton33 };
            string ResourcesPath = Directory.GetCurrentDirectory().Replace("bin\\Debug", "Resources");
            XImage = new Bitmap($"{ResourcesPath}\\x.png");
            OImage = new Bitmap($"{ResourcesPath}\\o.png");
            ObjConnector = new Connector();
            MainFormPositionY = Height / 2;
            MainFormPositionX = Width / 2;
            MainMoveForm = false;
            // Como são dois jogadores, cada um deles vai descontar uma unidade desta variável no TimerWin
            // Portanto ela é iniciada com o dobro do tempo que será contado de 3 até 1
            SecondsToRestart = 8; 
            CurrentPlayer = ObjConnector.HostAddress;
            IdPlayer = ObjConnector.HostAddress;
            AddPortsToCombo();
        }

        private void MainComboBoxPorta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string port = MainComboBoxPorta.Items[MainComboBoxPorta.SelectedIndex].ToString();

            try
            {
                MainLabelStatus.Text = "Conectando...";
                ObjConnector.PortName = port;
                ObjConnector.Open();
                MainLabelStatus.Text = "Conectado";
                MainComboBoxPorta.Enabled = false;
                SetTimers();
            } catch (Exception)
            {
                MessageBox.Show("Porta inválida!", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void TimerVerifyUSB_Tick(object sender, EventArgs e)
        {
            string Data = ObjConnector.ReadExisting();

            if (CurrentPlayer == IdPlayer) ReleaseButtons();
            else LockButtons();

            if (Data.Length != 0) ChangeCurrentPlayer();

            switch (Data) {
                case "x_11": UpdateScreen(MainButton11, XImage); break;
                case "o_11": UpdateScreen(MainButton11, OImage); break;
                case "x_12": UpdateScreen(MainButton12, XImage); break;
                case "o_12": UpdateScreen(MainButton12, OImage); break;
                case "x_13": UpdateScreen(MainButton13, XImage); break;
                case "o_13": UpdateScreen(MainButton13, OImage); break;
                case "x_21": UpdateScreen(MainButton21, XImage); break;
                case "o_21": UpdateScreen(MainButton21, OImage); break;
                case "x_22": UpdateScreen(MainButton22, XImage); break;
                case "o_22": UpdateScreen(MainButton22, OImage); break;
                case "x_23": UpdateScreen(MainButton23, XImage); break;
                case "o_23": UpdateScreen(MainButton23, OImage); break;
                case "x_31": UpdateScreen(MainButton31, XImage); break;
                case "o_31": UpdateScreen(MainButton31, OImage); break;
                case "x_32": UpdateScreen(MainButton32, XImage); break;
                case "o_32": UpdateScreen(MainButton32, OImage); break;
                case "x_33": UpdateScreen(MainButton33, XImage); break;
                case "o_33": UpdateScreen(MainButton33, OImage); break;
            }
        }

        private void TimerHandShakeUSB_Tick(object sender, EventArgs e)
        {
            string Data = ObjConnector.ReadExisting(); // Lê a porta USB
            if (Data.Length == 0) ObjConnector.Write(CurrentPlayer); // Caso não tenha nada, escreve o Host atual na porta

            if (Data.Contains("finish")) // Captura a flag de finalização do HandShake
            {
                StandbyPlayer = Data.Split('_')[0]; // A última informação, contém o jogador de espera na primeira posição 
                MainLabelTitulo.Text += $" ({IdPlayer} - X)";
                OwnLetter = 'x';
                TimerHandShakeUSB.Stop();
                TimerVerifyUSB.Start();
            }

            // O jogador que receber as informações primeiro, começará o jogo
            // Quando isso acontecer será mandado a informação do jogador em espera
            // Junto com a flag "_finish", informando que o handshake terminou
            if (CurrentPlayer != null && StandbyPlayer != null && (CurrentPlayer != IdPlayer)) 
            {
                ObjConnector.Write($"{StandbyPlayer}_finish");
                MainLabelTitulo.Text += $" ({IdPlayer} - O)";
                OwnLetter = 'o';
                TimerHandShakeUSB.Stop();
                TimerVerifyUSB.Start();
            }

            while (StandbyPlayer == null)
            {
                Data = ObjConnector.ReadExisting(); // Lê novamente a porta
                if (Data.Length != 0)               // Caso exista algo, atribui a leitura para StandbyPlayer e para o timer
                {
                    StandbyPlayer = Data;
                    ChangeCurrentPlayer();  // Troca os jogadores para que quem carregou as informações primeiro, comece jogando
                }
            }
        }


        private void TimerWin_Tick(object sender, EventArgs e)
        {
            Button[] Buttons = { MainButton11, MainButton12, MainButton13,
                                 MainButton21, MainButton22, MainButton23,
                                 MainButton31, MainButton32, MainButton33 };
            int SecondsToDisplay = SecondsToRestart / 2;
            LockButtons();
            TimerWin.Interval = 1000;
            if (WinnerPlayer == "Empate")
            {
                MainLabelStatus.Text = $"Empate (Reiniciando em {SecondsToDisplay})";
            }
            else
            {
                MainLabelStatus.Text = $"\" {WinnerPlayer} \" GANHOU !!! (Reiniciando em {SecondsToDisplay})";
            }
            SecondsToRestart--;

            if (SecondsToDisplay == 0)
            {
                foreach (Button Button_P in Buttons) Button_P.Image = null;
                if (MainLabelTitulo.Text.Contains('X'))
                {
                    MainLabelTitulo.Text = $" ({IdPlayer} - O)";
                    OwnLetter = 'o';
                }
                else if (MainLabelTitulo.Text.Contains('O'))
                {
                    MainLabelTitulo.Text = $" ({IdPlayer} - X)";
                    OwnLetter = 'x';
                }

                if (WinnerPlayer == "X" && MainLabelTitulo.Text.Contains('O')) ChangeCurrentPlayer();
                else if (WinnerPlayer == "X" && MainLabelTitulo.Text.Contains('X')) ChangeCurrentPlayer();
                ChangeCurrentPlayer();
                MainLabelStatus.Text = "Conectado";
                SecondsToRestart = 8;
                TimerWin.Stop();
                TimerVerifyUSB.Start();
            }
        }

        // ########################################### PROCEDURES ######################################################

        private void VerifyWin()
        {
            Image[,] Images = { { MainButton11.Image, MainButton12.Image, MainButton13.Image },
                                 { MainButton21.Image, MainButton22.Image, MainButton23.Image },
                                 { MainButton31.Image, MainButton32.Image, MainButton33.Image } };
            int[] HorizontalAccumulator = new int[3];
            int[] VerticalAccumulator = new int[3];
            int DiagPrincipalAccumulator = 0;
            int DiagSecundaryAccumulator = 0;
            int NumberOfPlays = 1;
            int XValue = 5;
            int OValue = 1;

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (Images[i, j] != null)
                    {
                        if (i + j == 2) DiagSecundaryAccumulator += (Images[i, j] == XImage) ? XValue : OValue;
                        if (i == j) DiagPrincipalAccumulator += (Images[i, j] == XImage) ? XValue : OValue;
                        HorizontalAccumulator[i] += (Images[i, j] == XImage) ? XValue : OValue;
                        VerticalAccumulator[i] += (Images[j, i] == XImage) ? XValue : OValue;
                        NumberOfPlays++;
                    }
                }

                if (HorizontalAccumulator.Sum() == 3*XValue || VerticalAccumulator.Sum() == 3*XValue || DiagPrincipalAccumulator == 3*XValue || DiagSecundaryAccumulator == 3*XValue)
                {
                    WinnerPlayer = "X";
                    TimerVerifyUSB.Stop();
                    TimerWin.Start();
                } else if ((HorizontalAccumulator.Sum() == 3 * OValue || VerticalAccumulator.Sum() == 3 * OValue || DiagPrincipalAccumulator == 3 * OValue || DiagSecundaryAccumulator == 3 * OValue))
                {
                    WinnerPlayer = "O";
                    TimerVerifyUSB.Stop();
                    TimerWin.Start();
                } else if (NumberOfPlays == 9)
                {
                    WinnerPlayer = "Empate";
                    TimerVerifyUSB.Stop();
                    TimerWin.Start();
                } else
                {
                    HorizontalAccumulator = new int[3];
                    VerticalAccumulator = new int[3];
                }
            }
        }

        private void AddPortsToCombo()
        {
            foreach (string port in ObjConnector.GetPortNames()) MainComboBoxPorta.Items.Add(port);
            if (MainComboBoxPorta.Items.Count <= 0) MainComboBoxPorta.Items.Add("Sem portas");
        }

        private void UpdateScreen(Button Button_P, Image Image_P)
        {
            Button_P.Image = Image_P;
            Button_P.Enabled = false;
            VerifyWin();
        }

        private void MakeMove(Button Button_P, string Position) // Realiza uma jogada
        {
            Button_P.Image = (OwnLetter == 'x') ? XImage : OImage;
            ObjConnector.Write($"{OwnLetter}_{Position}");
            ChangeCurrentPlayer();
            VerifyWin();
        }

        private void ChangeCurrentPlayer()
        {
            string AuxPlayer;

            AuxPlayer = CurrentPlayer;
            CurrentPlayer = StandbyPlayer;
            StandbyPlayer = AuxPlayer;
        }

        private void SetTimers()
        {
            TimerVerifyUSB.Interval = 100;
            TimerVerifyUSB.Tick += TimerVerifyUSB_Tick; // Timer usado para verificar eventos nos botões
            TimerHandShakeUSB.Interval = 500;
            TimerHandShakeUSB.Tick += TimerHandShakeUSB_Tick; // 
            TimerWin.Interval = 10;
            TimerWin.Tick += TimerWin_Tick;
            TimerHandShakeUSB.Start(); // Iniciar o timer até ocorrer uma comunicação
        }

        private void ReleaseButtons() 
        {
            Button[] Buttons = { MainButton11, MainButton12, MainButton13,
                                 MainButton21, MainButton22, MainButton23,
                                 MainButton31, MainButton32, MainButton33 };
            foreach (Button Button_P in Buttons) if (Button_P.Image == null) Button_P.Enabled = true;
        }

        private void LockButtons()
        {
            Button[] Buttons = { MainButton11, MainButton12, MainButton13,
                                 MainButton21, MainButton22, MainButton23,
                                 MainButton31, MainButton32, MainButton33 };

            foreach (Button Button_P in Buttons) Button_P.Enabled = false;
        }

        private void MainButton11_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton11, "11");
        }

        private void MainButton12_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton12, "12");
        }

        private void MainButton13_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton13, "13");
        }

        private void MainButton21_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton21, "21");
        }

        private void MainButton22_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton22, "22");
        }

        private void MainButton23_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton23, "23");
        }

        private void MainButton31_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton31, "31");
        }

        private void MainButton32_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton32, "32");
        }

        private void MainButton33_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton33, "33");
        }

        // ########################################### CONTROL ######################################################

        private void MainButtonExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void MainPanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainFormPositionX = e.X;
                MainFormPositionY = e.Y;
                MainMoveForm = true;
            }
        }

        private void MainPanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            MainMoveForm = false;
        }

        private void MainPanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (MainMoveForm)
            {
                Location = new Point(e.X + Location.X - MainFormPositionX, e.Y + Location.Y - MainFormPositionY);
            }
        }
    }  
}
