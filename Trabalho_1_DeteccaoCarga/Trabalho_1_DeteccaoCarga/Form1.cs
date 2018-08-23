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
            carregar_OpenFileDialog.InitialDirectory = @"C:\Users\Douglas\Desktop\visualAplicada\" + 
                                                       @"Trabalho_1_DeteccaoCarga\Trabalho_1_DeteccaoCarga\src";
            carregar_OpenFileDialog.RestoreDirectory = true;
            carregar_OpenFileDialog.Title = "Carregar Arquivo";
            carregar_OpenFileDialog.Filter= "Células Texto (*.txt)|*.txt|" +
                                            "Células Binário (*.bin)|*.bin|" +
                                            "Todos os Arquivos (*.*)|*.*";
            carregar_OpenFileDialog.DefaultExt = "txt";
            carregar_OpenFileDialog.CheckFileExists = true;
            carregar_OpenFileDialog.CheckPathExists = true;
            // carregar_OpenFileDialog.Multiselect = true;


            if(carregar_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                file_path = carregar_OpenFileDialog.FileName;
                file_name = carregar_OpenFileDialog.SafeFileName;
                textBox_pathFile.Text = file_name;
                getDataFromTXT();
                statusMessageMain_toolStripStatusLabel.Text = "Processando...";
                readingFile_progressBar.Visible = true;
               
            }
            
        }

        private void getDataFromTXT()
        {
            List<float> samples;
            List<double> times;
            float tmp_sum_samples;
            StreamReader file;
            string[] values;
            string line;
            int i;

            try
            {
                file = new StreamReader(file_path);
                times = new List<double>();
                samples = new List<float>();
                
                while ((line = file.ReadLine()) != null)
                {
                    values = line.Split('\t');
                    tmp_sum_samples = 0;
                    i = 0;

                    foreach (string value in values)
                    {                        
                        if (i == 0)
                        {
                            times.Add(Double.Parse(value));
                        }
                        else if (i != 1)
                        {
                            samples.Add(float.Parse(value));
                            tmp_sum_samples += float.Parse(value);
                            samples.Add(tmp_sum_samples);
                        }
                        i++;
                    }

                    foreach (float sample in samples)
                    {
                        Console.WriteLine(sample);
                    }
                }


            } catch (Exception e) {
                Console.WriteLine("Problemas ao ler o arquivo!");
                Console.WriteLine($"Exceção: {e}");
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
