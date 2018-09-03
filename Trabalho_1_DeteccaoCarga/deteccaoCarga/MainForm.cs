using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Data.SQLite;
using System.Drawing;
using System.Data;
using System.IO;
using System;

namespace deteccaoCarga
{
    public partial class Main : Form
    {
        private int MainFormPositionX;
        private int MainFormPositionY;
        private bool MainMoveForm;
        private Color darkGreyColor;
        private Color darkBlueColor;
        private Color whiteColor;
        private Color blueColor;
        private Color greyColor;
        private Color redColor;
        
        public Main()
        {
            darkBlueColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            darkGreyColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            whiteColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            blueColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            greyColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            redColor = Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(18)))), ((int)(((byte)(37)))));
            MainFormPositionY = Height / 2;
            MainFormPositionX = Width / 2;
            MainMoveForm = false;
            InitializeComponent();
            PopulateGrid(MainDataGrid);
        }

        private void MainButtonClose_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void MainButtonAbrir_Click(object sender, EventArgs e)
        {
            MoveMainButtonIndicator(MainButtonAbrir);   
            ChangeFooter(MainLabelStatusBar, MainProgressBarStatus, "Processando...", true);
            PopulateGrid(MainDataGrid);
            //MessageBox.Show("Dados Carregados com Sucesso!", "Sensor de Carga");
            ChangeFooter(MainLabelStatusBar, MainProgressBarStatus, "Dados carregados...", false);
        }

        public void PopulateGrid(BunifuCustomDataGrid dataGrid)
        {
            using (SQLiteConnection connector = new SQLiteConnection($"Data Source={getSrcPath()}\\database.db; Version=3"))
            {
                connector.Open();
                String command = "select * from samples";
                SQLiteDataAdapter data = new SQLiteDataAdapter(command, connector);

                using (DataTable dataTable = new DataTable())
                {
                    data.Fill(dataTable);
                    dataGrid.DataSource = dataTable;
                }
            }
        }

        private void MainButtonProcessar_Click(object sender, EventArgs e)
        {
            float[] selected_samples;
            Random random;

            if (MainPanelScrollLeftDataGrid.Visible)
            {
                MoveMainButtonIndicator(MainButtonProcessar);
                selected_samples = new float[2];
                random = new Random();

                //for (int i = 0; i < selected_samples.Length; i++) selected_samples[i] = samples[random.Next(0, samples.Count)].Last();
            }
            else
            {
                MessageBox.Show("Você deve carregar os dados!", "Sensor de Carga");
            }

        }

        private void MainButtonSair_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void MainButtonExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void MainButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainButtonMinimize_MouseHover(object sender, EventArgs e)
        {
            MainButtonMinimize.BackColor = greyColor;
        }

        private void MainButtonMinimize_MouseLeave(object sender, EventArgs e)
        {
            MainButtonMinimize.BackColor = darkGreyColor;
        }

        private void MainButtonExpandCompress_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void MainButtonExpandCompress_MouseHover(object sender, EventArgs e)
        {
            MainButtonExpandCompress.BackColor = greyColor;
        }

        private void MainButtonExpandCompress_MouseLeave(object sender, EventArgs e)
        {
            MainButtonExpandCompress.BackColor = darkGreyColor;
        }

        private void MainButtonExit_MouseHover(object sender, EventArgs e)
        {
            MainButtonExit.BackColor = redColor;
        }

        private void MainButtonExit_MouseLeave(object sender, EventArgs e)
        {
            this.MainButtonExit.BackColor = darkGreyColor;

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

        private OpenFileDialog CreateOpenFileDialog()
        {
            OpenFileDialog auxOpenFileDialog = new OpenFileDialog();
            auxOpenFileDialog.InitialDirectory = getSrcPath();
            auxOpenFileDialog.Title = "Carregar Arquivo";
            auxOpenFileDialog.DefaultExt = "txt";
            auxOpenFileDialog.Filter = "Células Texto (*.txt)|*.txt|" +
                                       "Células Binário (*.bin)|*.bin|" +
                                       "Todos os Arquivos (*.*)|*.*";
            return auxOpenFileDialog;
        }

        private String getSrcPath()
        {
            return Directory.GetCurrentDirectory().Replace(@"\bin\Debug", @"\src");
        }

        private void MoveMainButtonIndicator(Button referenceButton)
        {
            MainPanelButtonIndicator.Location = new Point(MainPanelButtonIndicator.Location.X, referenceButton.Location.Y);
        }

        private void ChangeFooter(Label statusLabel, BunifuProgressBar progressBar, string textLabel, Boolean visibilyProgress)
        {
            statusLabel.Text = textLabel;
            progressBar.Visible = visibilyProgress;
        }

        private void MainButtonAdicionar_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            MoveMainButtonIndicator(MainButtonAdicionar);
            addForm.Show();
        }

        private void MainButtonRemover_Click(object sender, EventArgs e)
        {
            RemoveForm removeForm = new RemoveForm();
            MoveMainButtonIndicator(MainButtonRemover);
            removeForm.Show();
        }
    }
}
