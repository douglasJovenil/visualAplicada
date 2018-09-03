using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace deteccaoCarga
{
    public partial class RemoveForm : Form
    {
        private int RemoveFormPositionX;
        private int RemoveFormPositionY;
        private bool RemoveMoveForm;

        public RemoveForm()
        {
            RemoveFormPositionY = Height / 2;
            RemoveFormPositionX = Width / 2;
            RemoveMoveForm = false;
            InitializeComponent();
        }

        private void RemovePanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RemoveFormPositionX = e.X;
                RemoveFormPositionY = e.Y;
                RemoveMoveForm = true;
            }
        }

        private void RemovePanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            RemoveMoveForm = false;
        }

        private void RemovePanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (RemoveMoveForm)
            {
                Location = new Point(e.X + Location.X - RemoveFormPositionX, e.Y + Location.Y - RemoveFormPositionY);
            }
        }

        private void RemoveButtonExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void RemoveButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RemoveButtonConfirmar_Click(object sender, EventArgs e)
        {
            if (RemoveCheckBoxRemoverPeloID.Checked)
            {
                using (SQLiteConnection connector = new SQLiteConnection($"Data Source={getSrcPath()}\\database.db; Version=3"))
                {
                    connector.Open();
                    using (SQLiteCommand terminal = new SQLiteCommand(connector))
                    {
                        terminal.CommandText = "delete from samples \n" +
                                               $"where id = \'{RemoveTextboxID.Text}\'";
                        terminal.ExecuteNonQuery();
                    }
                }
            }

            if (RemoveCheckBoxRemoverTodosOsDados.Checked)
            {
                using (SQLiteConnection connector = new SQLiteConnection($"Data Source={getSrcPath()}\\database.db; Version=3"))
                {
                    connector.Open();
                    using (SQLiteCommand terminal = new SQLiteCommand(connector))
                    {
                        terminal.CommandText = "delete from samples";
                        terminal.ExecuteNonQuery();
                    }
                }
            }


        }
        private String getSrcPath()
        {
            return Directory.GetCurrentDirectory().Replace(@"\bin\Debug", @"\src");
        }
    }
}


