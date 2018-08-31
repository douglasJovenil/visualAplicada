using System.Collections.Generic;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Drawing;
using System.Linq;
using System.IO;
using System;

namespace deteccaoCarga
{
    public partial class Main : Form
    {
        private int MainFormPositionX;
        private int MainFormPositionY;
        private bool MainMoveForm;
        private bool MainDataLoaded;
        private List<List<float>> samples;
        private List<double> times;
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
            samples = new List<List<float>>();
            times = new List<double>();
            MainDataLoaded = false;
            MainMoveForm = false;
            InitializeComponent();
        }

        private void MainButtonClose_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void MainButtonAbrir_Click(object sender, EventArgs e)
        {
            Tuple<List<double>, List<List<float>>> data;
            OpenFileDialog chargeOpenFileDialog;
            String[] MainDataGridColumns;
            List<List<float>> samples;
            List<double> times;
            String file_name;
            String file_path;

            chargeOpenFileDialog = CreateOpenFileDialog();
            MoveMainButtonIndicator(MainLabelAbrir);

            if (chargeOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                data = Tuple.Create(new List<double>(), new List<List<float>>());
                file_name = chargeOpenFileDialog.SafeFileName;
                file_path = chargeOpenFileDialog.FileName;
                MainDataGridColumns = new String[] { "Hora", "Amostra 1", "Amostra 2", "Amostra 3",
                                                     "Amostra 4", "Amostra 5", "Soma das Amostras" };

                ChangeFooter(MainStatusBar, MainProgressBar, "Processando...", true);
                data = getDataFromTXT(MainProgressBar, file_path);
                times = data.Item1;
                samples = data.Item2;
                MessageBox.Show("Dados Carregados com Sucesso!", "Sensor de Carga");
                ChangeFooter(MainStatusBar, MainProgressBar, "Dados carregados...", false);
                MainDataLoaded = true;
                MainLabelProgramName.Text += $" - {file_name}";
                PopulateGrid(MainDataGrid, MainDataGridColumns);
            }
        }

        private void MainButtonProcessar_Click(object sender, EventArgs e)
        {
            float[] selected_samples;
            Random random;

            if (MainDataLoaded)
            {
                MoveMainButtonIndicator(MainLabelProcessar);
                selected_samples = new float[2];
                random = new Random();

                for (int i = 0; i < selected_samples.Length; i++) selected_samples[i] = samples[random.Next(0, samples.Count)].Last();
            }
            else
            {
                MessageBox.Show("Você deve carregar os dados!", "Sensor de Carga");
            }


        }

        private void MainButtonSair_Click(object sender, EventArgs e)
        {
            MoveMainButtonIndicator(MainLabelSair);
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

        private Tuple<List<double>, List<List<float>>> getDataFromTXT(BunifuProgressBar readingFile_progressBar, string file_path)
        {
            List<float> samples_row;
            float tmp_sum_samples;
            StreamReader file;
            string[] values;
            string line;
            int column, step_progressBar;

            try
            {
                file = new StreamReader(file_path);
                times = new List<double>();
                samples = new List<List<float>>();
                step_progressBar = (int)Math.Ceiling((float)(100 / (file.ReadToEnd().Split('\n').Length)));
                file.BaseStream.Position = 0;

                while ((line = file.ReadLine()) != null)
                {
                    samples_row = new List<float>();
                    values = line.Split('\t');
                    tmp_sum_samples = 0;
                    column = 0;

                    foreach (string value in values)
                    {
                        if (column == 0)
                        {
                            times.Add(Double.Parse(value));
                        }
                        else if (column != 1)
                        {
                            samples_row.Add(float.Parse(value));
                            tmp_sum_samples += float.Parse(value);
                        }
                        column++;
                    }
                    readingFile_progressBar.Value += step_progressBar;
                    samples_row.Add(tmp_sum_samples);
                    samples.Add(samples_row);
                }
                readingFile_progressBar.Value += 100 - readingFile_progressBar.Value;
                return Tuple.Create(times, samples);

            }
            catch (Exception e)
            {
                Console.WriteLine("Problemas ao ler o arquivo!");
                Console.WriteLine($"Exceção: {e}");
                return Tuple.Create(new List<double>(), new List<List<float>>());
            }
        }

        private OpenFileDialog CreateOpenFileDialog()
        {
            OpenFileDialog auxOpenFileDialog = new OpenFileDialog();
            auxOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory().Replace(@"\bin\Debug", @"\src");
            auxOpenFileDialog.Title = "Carregar Arquivo";
            auxOpenFileDialog.DefaultExt = "txt";
            auxOpenFileDialog.Filter = "Células Texto (*.txt)|*.txt|" +
                                       "Células Binário (*.bin)|*.bin|" +
                                       "Todos os Arquivos (*.*)|*.*";
            return auxOpenFileDialog;
        }

        private void PopulateGrid(BunifuCustomDataGrid dataGrid, String[] gridColumns)
        {
            foreach (String columnName in gridColumns)
            {
                dataGrid.Columns.Add(columnName, columnName);
            }

            for (int i = 0; i < samples.Count; i++)
            {
                dataGrid.Rows.Add(times[i], samples[i][0], samples[i][1], samples[i][2], samples[i][3], samples[i][4], samples[i][5]);
            }

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void MoveMainButtonIndicator(BunifuCustomLabel referenceLabel)
        {
            MainButtonIndicator.Location = new Point(MainButtonIndicator.Location.X, referenceLabel.Location.Y + 6);
        }

        private void ChangeFooter(Label statusLabel, BunifuProgressBar progressBar, string textLabel, Boolean visibilyProgress)
        {
            statusLabel.Text = textLabel;
            progressBar.Visible = visibilyProgress;
        }

    }
}
