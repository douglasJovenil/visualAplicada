using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System;

namespace deteccaoCarga
{
    public partial class AddForm : Form
    {
        private int AddFormPositionX;
        private int AddFormPositionY;
        private bool AddMoveForm;

        public AddForm()
        {
            AddFormPositionY = Height / 2;
            AddFormPositionX = Width / 2;
            AddMoveForm = false;
            InitializeComponent();
            AddTextboxDia.Text = DateTime.Now.ToString("dd/MM/yyyy");
            AddTextboxHora.Text = DateTime.Now.ToString("hh:mm:ss");

        }

        private void AddButtonExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void AddPanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AddFormPositionX = e.X;
                AddFormPositionY = e.Y;
                AddMoveForm = true;
            }
        }

        private void AddPanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            AddMoveForm = false;
        }

        private void AddPanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (AddMoveForm)
            {
                Location = new Point(e.X + Location.X - AddFormPositionX, e.Y + Location.Y - AddFormPositionY);
            }
        }

        private void AddButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AddTextboxAmostra_1_GotFocus(object sender, EventArgs e)
        {
            AddTextboxAmostra_1.Text = String.Empty;
        }

        private void AddButtonConfirmar_Click(object sender, EventArgs e)
        {
            Int64 day = Int64.Parse(AddTextboxDia.Text.Replace("/", ""));
            Int64 time = Int64.Parse(AddTextboxHora.Text.Replace(":", ""));
            float[] samples = new float[5];
            BunifuMetroTextbox[] textboxs = { AddTextboxAmostra_1, AddTextboxAmostra_2,
                                              AddTextboxAmostra_3, AddTextboxAmostra_4,
                                              AddTextboxAmostra_5 };
            float auxSum = 0;

            try
            {
                for (int i = 0; i < samples.Length; i++)
                {
                    samples[i] = float.Parse(textboxs[i].Text);
                    auxSum += float.Parse(textboxs[i].Text);
                    AddTextboxSoma.Text = auxSum.ToString();
                }

                using (SQLiteConnection connector = new SQLiteConnection($"Data Source={getSrcPath()}\\database.db; Version=3"))
                {
                    connector.Open();
                    using (SQLiteCommand terminal = new SQLiteCommand(connector))
                    {
                        String command = "insert into samples (days, times, \"sample 1\", \"sample 2\", \"sample 3\", \"sample 4\", \"sample 5\", sumSamples) " +
                                     $"values ({day}, {time}, {samples[0]}, {samples[1]}, {samples[2]}, {samples[3]}, {samples[4]}, {auxSum})";

                        terminal.CommandText = command;
                        terminal.ExecuteNonQuery();
                    }
                    connector.Close();
                }
            } catch
            {
                MessageBox.Show("Informar valores válidos!", "Sensor de Carga");
            }
        }




        private String getSrcPath()
        {
            return Directory.GetCurrentDirectory().Replace(@"\bin\Debug", @"\src");
        }

    }
}
