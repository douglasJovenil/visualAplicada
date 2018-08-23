using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_1_DeteccaoCarga
{
    public partial class Form1 : Form
    {
        private OpenFileDialog carregar_OpenFileDialog = new OpenFileDialog();
        private Boolean state_button_chageFileName = false;
        public Form1()
        {   
            InitializeComponent();
        }

        private void carregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            carregar_OpenFileDialog.RestoreDirectory = false;
            carregar_OpenFileDialog.InitialDirectory = @"C:\";
            carregar_OpenFileDialog.Title = "Carregar Arquivo";
            carregar_OpenFileDialog.Filter = "Células Texto (*.txt) | *.txt|" +
                                             "Células Binário (*.bin) | *.bin|" +
                                             "Todos os Arquivos (*.*) | *.*";
            carregar_OpenFileDialog.FilterIndex = 1;
            carregar_OpenFileDialog.DefaultExt = "txt";
            carregar_OpenFileDialog.CheckFileExists = true;
            carregar_OpenFileDialog.CheckPathExists = true;
            // carregar_OpenFileDialog.Multiselect = true;

            if(carregar_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_pathFile.Text = carregar_OpenFileDialog.SafeFileName;
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_pathFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_changeFileName_Click(object sender, EventArgs e)
        {
            if (state_button_chageFileName)
            {
                textBox_pathFile.Text = carregar_OpenFileDialog.SafeFileName;
            } else
            {
                textBox_pathFile.Text = carregar_OpenFileDialog.FileName;
            }
            state_button_chageFileName = !state_button_chageFileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
