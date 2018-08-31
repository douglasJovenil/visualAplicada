using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deteccaoCarga
{
    public partial class Main : Form
    {
        private int MainFormPositionX;
        private int MainFormPositionY;
        private bool MainMoveForm;
        private bool MainFormExpanded;
        private bool MainDataLoaded;
        private String file_name;
        private String file_path;
        private List<List<float>> samples;
        private List<double> times;

        public Main()
        {
            MainFormPositionX = Width / 2;
            MainFormPositionY = Height / 2;
            MainMoveForm = false;
            MainFormExpanded = false;
            MainDataLoaded = false;
            InitializeComponent();
            
        }


        private void MainButtonClose_Click(object sender, EventArgs e)
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

        private void MainButtonAbrir_Click(object sender, EventArgs e)
        {
            MainButtonIndicator.Location = new Point(MainButtonIndicator.Location.X, MainLabelAbrir.Location.Y + 6);
            OpenFileDialog carregar_OpenFileDialog = new OpenFileDialog();
            carregar_OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory().Replace(@"\bin\Debug", @"\src");
            carregar_OpenFileDialog.Title = "Carregar Arquivo";
            carregar_OpenFileDialog.Filter = "Células Texto (*.txt)|*.txt|" +
                                            "Células Binário (*.bin)|*.bin|" +
                                            "Todos os Arquivos (*.*)|*.*";
            carregar_OpenFileDialog.DefaultExt = "txt";
            carregar_OpenFileDialog.CheckFileExists = true;
            carregar_OpenFileDialog.CheckPathExists = true;
            List<double> times = new List<double>();
            List<List<float>> samples = new List<List<float>>();
            Tuple<List<double>, List<List<float>>> data = Tuple.Create(new List<double>(), new List<List<float>>());
            String[] MainDataGridColumns;

            if (carregar_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                file_path = carregar_OpenFileDialog.FileName;
                file_name = carregar_OpenFileDialog.SafeFileName;
                changeFooter(MainStatusBar, MainProgressBar, "Processando...", true);
                data = getDataFromTXT(MainProgressBar);
                times = data.Item1;
                samples = data.Item2;
                MessageBox.Show("Dados Carregados com Sucesso!", "Sensor de Carga");
                changeFooter(MainStatusBar, MainProgressBar, "Dados carregados...", false);
                MainDataLoaded = true;
                MainLabelProgramName.Text += $" - {file_name}";
                MainDataGridColumns = new String[] { "Hora", "Amostra 1", "Amostra 2", "Amostra 3", "Amostra 4", "Amostra 5", "Soma das Amostras" };

                foreach (String columnName in MainDataGridColumns)
                {
                    MainDataGrid.Columns.Add(columnName, columnName);
                }

                for (int i = 0; i < samples.Count; i++)
                {
                    MainDataGrid.Rows.Add(times[i], samples[i][0], samples[i][1], samples[i][2], samples[i][3], samples[i][4], samples[i][5]);
                }

                foreach (DataGridViewRow row in MainDataGrid.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }

            }
        }


        private void changeFooter(Label statusLabel, Bunifu.Framework.UI.BunifuProgressBar progressBar, string textLabel, Boolean visibilyProgress)
        {
            statusLabel.Text = textLabel;
            progressBar.Visible = visibilyProgress;
        }

        private Tuple<List<double>, List<List<float>>> getDataFromTXT(Bunifu.Framework.UI.BunifuProgressBar readingFile_progressBar)
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

                Console.WriteLine(step_progressBar);

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

        private void MainButtonProcessar_Click(object sender, EventArgs e)
        {
            float[] selected_samples;
            Random random;

            if (MainDataLoaded)
            {
                MainButtonIndicator.Location = new Point(MainButtonIndicator.Location.X, MainLabelProcessar.Location.Y + 6);
                selected_samples = new float[2];
                random = new Random();

                for (int i = 0; i < selected_samples.Length; i++) selected_samples[i] = samples[random.Next(0, samples.Count)].Last();
            } else
            {
                MessageBox.Show("Você deve carregar os dados!", "Sensor de Carga");
            }


        }

        private void MainButtonSair_Click(object sender, EventArgs e)
        {
            MainButtonIndicator.Location = new Point(MainButtonIndicator.Location.X, MainLabelSair.Location.Y + 6);
            ActiveForm.Close();
        }

        private void MainProgressBar_progressChanged(object sender, EventArgs e)
        {

        }

        private void MainButtonExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void MainButtonExit_MouseHover(object sender, EventArgs e)
        {
            MainButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(18)))), ((int)(((byte)(37)))));
        }

        private void MainButtonExit_MouseLeave(object sender, EventArgs e)
        {
            this.MainButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));

        }

        private void MainMinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainExpandCompressButton_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal && !MainFormExpanded)
            {
                WindowState = FormWindowState.Maximized;
                MainFormExpanded = true;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                MainFormExpanded = false;
            }

        }

        private void MainButtonSair_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
