using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_4_Programacao_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            soma();
        }

        private void operator_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            limpa();
        }

        private void somarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void somarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            soma();
        }

        private void soma()
        {
            try
            {
                double op1 = Convert.ToDouble(textbox_operator_1.Text);
                double op2 = Convert.ToDouble(textbox_operator_2.Text);
                double result = op1 + op2;
                textbox_result.Text = result.ToString();
            }
            catch (Exception e)
            {
                limpa();
                textbox_result.Text = "Informe um número!";
            }
            
        }

        private void limpa()
        {
            textbox_operator_1.Clear();
            textbox_operator_2.Clear();
            textbox_result.Clear();
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpa();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textbox_operator_2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
