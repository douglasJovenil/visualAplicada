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
            LoadDataToMainChartAlunos("Standard");
        }

        private void LoadDataToMainChartAlunos(String Option)
        {
            Series serie;
            MainChartAlunos.Series.Clear();

            switch (Option)
            {
                case "Standard":
                    MainChartAlunos.ChartAreas[0].AxisY.Minimum = 0;
                    foreach (Aluno aluno in Alunos)
                    {
                        serie = MainChartAlunos.Series.Add(aluno.Nome);
                        serie.Points.Add(aluno.Nota);
                    }
                break;
                case "BoxPlot":
                    /*
                        // Add data to Box Plot Source series.
                        yValues = {55.62, 45.54, 73.45, 9.73, 88.42, 45.9, 63.6, 85.1, 67.2, 23.6};
                        Chart1.Series["DataSeries"].Points.DataBindY(yValues);

                        // Specify data series name for the Box Plot.
                        Chart1.Series["BoxPlotSeries"]["BoxPlotSeries"] = "DataSeries";

                        // Set other custom attributes
                        Chart1.Series["BoxPlotSeries"]["BoxPlotWhiskerPercentile"] = "15";
                        Chart1.Series["BoxPlotSeries"]["BoxPlotShowAverage"] = "true";
                        Chart1.Series["BoxPlotSeries"]["BoxPlotShowMedian"] = "true";
                        Chart1.Series["BoxPlotSeries"]["BoxPlotShowUnusualValues"] = "true";
                     */
                    MainChartAlunos.ChartAreas[0].AxisY.Minimum = -10;
                    serie = MainChartAlunos.Series.Add("BoxPlotSeries");
                    MainChartAlunos.Series["BoxPlotSeries"]["BoxPlotWhiskerPercentile"] = "15";
                    MainChartAlunos.Series["BoxPlotSeries"]["BoxPlotShowAverage"] = "true";
                    MainChartAlunos.Series["BoxPlotSeries"]["BoxPlotShowMedian"] = "true";
                    MainChartAlunos.Series["BoxPlotSeries"]["BoxPlotShowUnusualValues"] = "true";
                    serie.ChartType = SeriesChartType.BoxPlot;
                    serie.Points.DataBindY(Alunos.Select(obj => (obj.Nota > 5) ? obj.Nota : -10).ToArray());

                    

                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                break;
            }
        }

        private void MainButtonNome_Click(object sender, EventArgs e)
        {
            Alunos = Alunos.OrderBy(obj => obj.Nome).ToList();
            LoadDataToMainChartAlunos("Standard");
        }

        private void MainButtonNota_Click(object sender, EventArgs e)
        {
            Alunos = Alunos.OrderBy(obj => obj.Nota).ToList();
            LoadDataToMainChartAlunos("Standard");
        }

        /* // Set other custom attributes
           Chart1.Series["BoxPlotSeries"]["BoxPlotWhiskerPercentile"] = "15";
           Chart1.Series["BoxPlotSeries"]["BoxPlotShowAverage"] = "true";
           Chart1.Series["BoxPlotSeries"]["BoxPlotShowMedian"] = "true";
           Chart1.Series["BoxPlotSeries"]["BoxPlotShowUnusualValues"] = "true"; */

        private void MainButtonBoxPlot_Click(object sender, EventArgs e)
        {
            LoadDataToMainChartAlunos("BoxPlot");   
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

        private void MainButtonSair_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
