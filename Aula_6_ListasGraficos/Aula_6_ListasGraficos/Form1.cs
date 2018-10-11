using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Aula_6_ListasGraficos
{
    public partial class MainForm : Form
    {
        private List<Aluno> Alunos;
        public MainForm()
        {
            InitializeComponent();

            ConstructorMainChartAlunos();
            PopulateListAlunos();
            LoadDataToMainChartAlunos();
        }

        private void LoadDataToMainChartAlunos()
        {
            Series serie;
            MainChartAlunos.Series.Clear();

            foreach (Aluno aluno in Alunos)
            {
                serie = MainChartAlunos.Series.Add(aluno.Nome);
                serie.Points.Add(aluno.Nota);
            }
        }

        private void ConstructorMainChartAlunos()
        {
            Alunos = new List<Aluno>();
            MainChartAlunos.Palette = ChartColorPalette.EarthTones;
            MainChartAlunos.Titles.Add("Notas");
            MainChartAlunos.ChartAreas[0].AxisY.Maximum = 10;
        }

        private void PopulateListAlunos() 
        {
            Alunos.Add(new Aluno("dougras", 7.5));
            Alunos.Add(new Aluno("dogras", 7.0));
            Alunos.Add(new Aluno("dugras", 6.7));
            Alunos.Add(new Aluno("dorgas", 7.5));
            Alunos.Add(new Aluno("fjnksdf", 7.5));
            Alunos.Add(new Aluno("caguei", 6.5));
            Alunos.Add(new Aluno("asdc", 7.0));
            Alunos.Add(new Aluno("xablau", 9.5));
        }

        private void MainButtonNome_Click(object sender, EventArgs e)
        {
            Alunos = Alunos.OrderBy(obj => obj.Nome).ToList();
            LoadDataToMainChartAlunos();
        }

        private void MainButtonNota_Click(object sender, EventArgs e)
        {
            Alunos = Alunos.OrderBy(obj => obj.Nota).ToList();
            LoadDataToMainChartAlunos();
        }
    }
}
