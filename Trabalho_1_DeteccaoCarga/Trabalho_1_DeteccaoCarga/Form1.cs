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

namespace Trabalho_1_DeteccaoCarga
{
    public partial class Form_Main : Form
    {
        private Boolean state_button_chageFileName;
        private String file_name;
        private String file_path;
        
        public Form_Main()
        {
            state_button_chageFileName = false;
            InitializeComponent();
        }

        private void carregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog carregar_OpenFileDialog = new OpenFileDialog();
            carregar_OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory().Replace(@"\bin\Debug", @"\src");
            carregar_OpenFileDialog.Title = "Carregar Arquivo";
            carregar_OpenFileDialog.Filter= "Células Texto (*.txt)|*.txt|" +
                                            "Células Binário (*.bin)|*.bin|" +
                                            "Todos os Arquivos (*.*)|*.*";
            carregar_OpenFileDialog.DefaultExt = "txt";
            carregar_OpenFileDialog.CheckFileExists = true;
            carregar_OpenFileDialog.CheckPathExists = true;
            List<double> times = new List<double>();
            List<List<float>> samples = new List<List<float>>();
            Tuple<List<double>, List<List<float>>> data = Tuple.Create(new List<double>(), new List<List<float>>());

            if (carregar_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                file_path = carregar_OpenFileDialog.FileName;
                file_name = carregar_OpenFileDialog.SafeFileName;
                textBox_pathFile.Text = file_name;
                changeFooter(statusMessageMain_toolStripStatusLabel, readingFile_progressBar, "Processando...", true);
                getDataFromTXT(readingFile_progressBar);
                data = getDataFromTXT(readingFile_progressBar);
                times = data.Item1;
                samples = data.Item2;
            }

            /* if (times[0] != -1)
            {
                changeFooter(statusMessageMain_toolStripStatusLabel, readingFile_progressBar, "Arquivos processados...", false);
            } */


        }

        private void changeFooter(ToolStripStatusLabel statusLabel, ProgressBar progressBar, string textLabel, Boolean visibilyProgress)
        {
            statusLabel.Text = textLabel;
            progressBar.Visible = visibilyProgress;
        }

        private Tuple< List<double>, List<List<float>> > getDataFromTXT(ProgressBar readingFile_progressBar)
        {
            List<List<float>> samples;
            List<double> times;
            List<float> samples_row;
            float tmp_sum_samples;
            StreamReader file;
            string[] values;
            string line;
            int column, quantity_chars, increase_progressBar;

            try
            {
                file = new StreamReader(file_path);
                times = new List<double>();
                samples = new List<List<float>>();
                quantity_chars = file.ReadToEnd().Length;
                increase_progressBar = (quantity_chars / 100);

                
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
                        readingFile_progressBar.Increment(increase_progressBar); // stopped here
                    }

                    samples_row.Add(tmp_sum_samples);
                    samples.Add(samples_row);
                }

                return Tuple.Create(times, samples);

            } catch (Exception e) {
                Console.WriteLine("Problemas ao ler o arquivo!");
                Console.WriteLine($"Exceção: {e}");
                return Tuple.Create(new List<double>{-1}, new List<List<float>>());
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_changeFileName_Click(object sender, EventArgs e)
        {
            if (state_button_chageFileName)
            {
                textBox_pathFile.Text = file_name;
            } else
            {
                textBox_pathFile.Text = file_path;
            }
            state_button_chageFileName = !state_button_chageFileName;
        }

        private void statusMessageMain_toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void readingFile_progressBar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_pathFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
