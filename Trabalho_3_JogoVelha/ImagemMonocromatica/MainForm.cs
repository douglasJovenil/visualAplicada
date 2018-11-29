using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System;

namespace ImagemMonocromatica
{
    public partial class MainForm : Form
    {
        private Player ObjPlayer;
        private Window ObjWindow;
        private int SecondsToRestart;
        private PointHistoric[,] PlayHistory;

        public MainForm()
        {
            InitializeComponent();
        }

        // ############################################# MÉTODOS DE INICIALIZAÇÃO ######################################################

        private void MainForm_Load(object sender, EventArgs e)
        {
            ObjWindow = new Window(Height, Width);
            ObjPlayer = new Player();
            MainLabelTitulo.Text = $"Jogo da Velha ({ObjPlayer.PlayerID})";
            foreach (string port in ObjPlayer.GetPortNames()) MainComboBoxPorta.Items.Add(port); // Adiciona as portas na ComboBox
            if (MainComboBoxPorta.Items.Count <= 0) MainComboBoxPorta.Items.Add("Sem portas");
            SecondsToRestart = 8; // Como são dois jogadores, cada um deles vai descontar uma unidade desta variável
            PlayHistory = new PointHistoric[3, 3];
        }

        private void MainComboBoxPorta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string port = MainComboBoxPorta.Items[MainComboBoxPorta.SelectedIndex].ToString();

            try
            {
                MainLabelStatus.Text = "Conectando...";
                ObjPlayer.PortName = port;
                ObjPlayer.Open();
                MainLabelStatus.Text = "Conectado";
                MainComboBoxPorta.Enabled = false;
                SetTimers();
            } catch (Exception)
            {
                MessageBox.Show("Porta inválida!", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        // ############################################# MÉTODOS PERIÓDICOS ######################################################

        private void MakeMove(Button Button_P, string Position) // Realiza uma jogada
        {
            string[] Index = Position.Split('_');
            int i = int.Parse(Index[0]) - 1;
            int j = int.Parse(Index[1]) - 1;

            TimerTimeOut.Stop(); // Após a jogada, começa a contar o timeout
            TimerTimeOut.Start();

            PlayHistory[i, j] = new PointHistoric(ObjPlayer.PlayerValue, i, j);

            ObjPlayer.Write($"{ObjPlayer.PlayerLetter}_{Position}");
            ObjPlayer.NumberOfPlays++;
            ObjPlayer.ChangeTurn();
            Button_P.Image = ObjPlayer.PlayerImage;
            TimerVerifyAccumulators.Stop();
            TimerVerifyAccumulators.Start();
        }

        private void UpdateScreen(Button Button_P, Image Image_P, int i, int j)
        {
            PlayHistory[i - 1, j - 1] = new PointHistoric(ObjPlayer.OpponentValue, i - 1, j - 1);
            Button_P.Image = Image_P;
            Button_P.Enabled = false;
            TimerVerifyAccumulators.Stop();
            TimerVerifyAccumulators.Start();
            ObjPlayer.ChangeTurn();
        }

        private void CheckAccumulators()
        {
            int[] Horizontal = new int[3];
            int[] Vertical = new int[3];
            int DiagPrincipal = 0;
            int DiagSecundary = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i + j == 2) DiagSecundary += PlayHistory[i, j].Value;
                    if (i == j) DiagPrincipal += PlayHistory[i, j].Value;
                    Horizontal[i] += PlayHistory[i, j].Value;
                    Vertical[i] += PlayHistory[j, i].Value;
                }
                CheckWinner(DiagPrincipal, DiagSecundary, Horizontal.Sum(), Vertical.Sum());
                Horizontal = new int[3];
                Vertical = new int[3];
            }
        }

        public void CheckWinner(int DiagPrincipal, int DiagSecundary, int Horizontal, int Vertical)
        {

            if (ObjPlayer.NumberOfPlays == 5) // Empate
            {
                ObjPlayer.Winner = 'e';
                ObjPlayer.Write($"_e_tie");
                TimerVerifyAccumulators.Stop();
                TimerVerifyUSB.Stop();
                TimerWin.Start();
            }
            else if (DiagPrincipal == ObjPlayer.PlayerWinValue || DiagSecundary == ObjPlayer.PlayerWinValue || Horizontal == ObjPlayer.PlayerWinValue || Vertical == ObjPlayer.PlayerWinValue)
            {
                ObjPlayer.Winner = ObjPlayer.PlayerLetter;
                ObjPlayer.Write($"{ObjPlayer.PlayerLetter}_end");
                PlayHistory = new PointHistoric[3, 3];
                TimerVerifyAccumulators.Stop();
                TimerVerifyUSB.Stop();
                TimerWin.Start();
            }
        }

        private void ResetGame() 
        {
            Button[] Buttons = { MainButton11, MainButton12, MainButton13,
                                 MainButton21, MainButton22, MainButton23,
                                 MainButton31, MainButton32, MainButton33};

            ObjPlayer.ResetChangePlayer();
            MainLabelTitulo.Text = $"Jogo da Velha ({ObjPlayer.PlayerID} - {char.ToUpper(ObjPlayer.PlayerLetter)})";
            MainLabelStatus.Text = "Conectado";
            foreach (Button Button_P in Buttons) Button_P.Image = null;
            PlayHistory = new PointHistoric[3, 3];
            SecondsToRestart = 8;

            if (ObjPlayer.PlayerLetter == 'x') ObjPlayer.Turn = true;
            else if (ObjPlayer.PlayerLetter == 'o') ObjPlayer.Turn = false;
    
            TimerVerifyUSB.Start();
            TimerVerifyAccumulators.Start();
        }

        // ############################################# TIMERS ######################################################

        private void SetTimers()
        {
            TimerVerifyUSB.Interval = 100;
            TimerVerifyUSB.Tick += TimerVerifyUSB_Tick; // Timer usado para verificar eventos nos botões
            TimerHandShakeUSB.Interval = 100;
            TimerHandShakeUSB.Tick += TimerHandShakeUSB_Tick; // 
            TimerWin.Interval = 1000;
            TimerWin.Tick += TimerWin_Tick;
            TimerTimeOut.Interval = 600000; // 10 minutos
            TimerTimeOut.Tick += TimerTimeOut_Tick;
            TimerVerifyAccumulators.Interval = 100;
            TimerVerifyAccumulators.Tick += TimerVerifyAccumulators_Tick;
            TimerVerifyAccumulators.Start();
            TimerHandShakeUSB.Start(); // Iniciar o timer até ocorrer uma comunicação
        }

        private void TimerVerifyAccumulators_Tick(object sender, EventArgs e)
        {
            CheckAccumulators();
        }

        private void TimerHandShakeUSB_Tick(object sender, EventArgs e)
        {
            string Data;

            ObjPlayer.Write($"{ObjPlayer.PlayerID}");

            while (string.IsNullOrEmpty(ObjPlayer.OpponentID))
            {
                Data = ObjPlayer.ReadExisting();
                if (!Data.Contains("start"))
                {
                    ObjPlayer.SetPlayer(Data, 'x', 'o', 'x', 'o', 5, 1, true);
                    MainLabelTitulo.Text = $"Jogo da Velha ({ObjPlayer.PlayerID} - X)";
                    ReleaseButtons();
                }
                // É utilizado o split, pois o último que carrega as informações na porta usb 
                // Possui a flag "start", portanto é necessário separar para pegar o ID do 
                // Primeiro a carregar que se encontra na primeira posição
                else
                {
                    ObjPlayer.SetPlayer(Data.Split('_')[0], 'o', 'x', 'o', 'x', 1, 5, false);
                    MainLabelTitulo.Text = $"Jogo da Velha ({ObjPlayer.PlayerID} - O)";
                }
            }

            ObjPlayer.Write($"{ObjPlayer.PlayerID}_start");
            TimerHandShakeUSB.Stop();
            TimerTimeOut.Start();
            TimerVerifyUSB.Start();
        }

        private void TimerVerifyUSB_Tick(object sender, EventArgs e)
        {
            string Data = ObjPlayer.ReadExisting();

            ObjPlayer.DiscardInBuffer();
            ObjPlayer.DiscardOutBuffer();
            if (ObjPlayer.Turn) ReleaseButtons();
            else LockButtons();

            switch (Data)
            {
                case "x_1_1": UpdateScreen(MainButton11, ObjPlayer.OpponentImage, 1, 1); break;
                case "o_1_1": UpdateScreen(MainButton11, ObjPlayer.OpponentImage, 1, 1); break;
                case "x_1_2": UpdateScreen(MainButton12, ObjPlayer.OpponentImage, 1, 2); break;
                case "o_1_2": UpdateScreen(MainButton12, ObjPlayer.OpponentImage, 1, 2); break;
                case "x_1_3": UpdateScreen(MainButton13, ObjPlayer.OpponentImage, 1, 3); break;
                case "o_1_3": UpdateScreen(MainButton13, ObjPlayer.OpponentImage, 1, 3); break;
                case "x_2_1": UpdateScreen(MainButton21, ObjPlayer.OpponentImage, 2, 1); break;
                case "o_2_1": UpdateScreen(MainButton21, ObjPlayer.OpponentImage, 2, 1); break;
                case "x_2_2": UpdateScreen(MainButton22, ObjPlayer.OpponentImage, 2, 2); break;
                case "o_2_2": UpdateScreen(MainButton22, ObjPlayer.OpponentImage, 2, 3); break;
                case "x_2_3": UpdateScreen(MainButton23, ObjPlayer.OpponentImage, 2, 3); break;
                case "o_2_3": UpdateScreen(MainButton23, ObjPlayer.OpponentImage, 2, 3); break;
                case "x_3_1": UpdateScreen(MainButton31, ObjPlayer.OpponentImage, 3, 1); break;
                case "o_3_1": UpdateScreen(MainButton31, ObjPlayer.OpponentImage, 3, 1); break;
                case "x_3_2": UpdateScreen(MainButton32, ObjPlayer.OpponentImage, 3, 2); break;
                case "o_3_2": UpdateScreen(MainButton32, ObjPlayer.OpponentImage, 3, 2); break;
                case "x_3_3": UpdateScreen(MainButton33, ObjPlayer.OpponentImage, 3, 3); break;
                case "o_3_3": UpdateScreen(MainButton33, ObjPlayer.OpponentImage, 3, 3); break;
            }


            if (Data.Contains("end"))
            {
                ObjPlayer.Winner = Convert.ToChar(Data.Split('_')[0]); // Vencedor está na primeira posição
                TimerVerifyUSB.Stop();
                TimerWin.Start();
            } else if (Data.Contains("tie"))
            {
                string[] DataArray = Data.Split('_');
                Button[,] Buttons = { { MainButton11, MainButton12, MainButton13 },
                                      { MainButton21, MainButton22, MainButton23 },
                                      { MainButton31, MainButton32, MainButton33} };

                for (int i = 0; i < 3; i++) // Encontrar o último botão sem imagem
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (PlayHistory[i, j].Value == 0) Buttons[i, j].Image = ObjPlayer.OpponentImage;
                    }
                }

                ObjPlayer.Winner = Convert.ToChar(DataArray[DataArray.Length - 2]); // Informação de empate está na penultima posição
                TimerVerifyUSB.Stop();
                TimerWin.Start();
            }
        }

        private void TimerWin_Tick(object sender, EventArgs e)
        {
            LockButtons();
            int SecondsToDisplay = SecondsToRestart / 2;
            if (ObjPlayer.Winner == 'e')
            {
                MainLabelStatus.Text = $"Empate (Reiniciando em {SecondsToDisplay})";
            }
            else
            {
                MainLabelStatus.Text = $"\" {char.ToUpper(ObjPlayer.Winner)} \" GANHOU !!! (Reiniciando em {SecondsToDisplay})";
            }
            SecondsToRestart--;

            if (SecondsToDisplay == 0)
            {
                TimerWin.Stop();
                ResetGame();
            }
        }

        private void TimerTimeOut_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ########################################### FUNÇÕES DOS BOTÕES ######################################################

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

        // ########################################### CONTROLE DOS BOTÕES ######################################################

        private void MainButton11_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton11, "1_1");
        }

        private void MainButton12_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton12, "1_2");
        }

        private void MainButton13_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton13, "1_3");
        }

        private void MainButton21_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton21, "2_1");
        }

        private void MainButton22_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton22, "2_2");
        }

        private void MainButton23_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton23, "2_3");
        }

        private void MainButton31_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton31, "3_1");
        }

        private void MainButton32_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton32, "3_2");
        }

        private void MainButton33_Click(object sender, EventArgs e)
        {
            MakeMove(MainButton33, "3_3");
        }

        // ########################################### CONTROLE DA JANELA ######################################################

        private void MainButtonExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void MainPanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ObjWindow.MouseDown(e);
        }

        private void MainPanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            ObjWindow.MouseUp(e);
        }

        private void MainPanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            Location = ObjWindow.MouseMove(e, Location);
        }
    }  
}
