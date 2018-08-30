using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deteccaoCarga
{
    public partial class Main : Form
    {
        int MainFormPositionX;
        int MainFormPositionY;
        bool MainMoveForm;

        public Main()
        {
            MainFormPositionX = Width / 2;
            MainFormPositionY = Height / 2;
            MainMoveForm = false;
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
            MainButtonIndicator.Location = new Point(MainButtonIndicator.Location.X, MainLabelAbrir.Location.Y);
        }

        private void MainButtonProcessar_Click(object sender, EventArgs e)
        {
            MainButtonIndicator.Location = new Point(MainButtonIndicator.Location.X, MainLabelProcessar.Location.Y);
        }

        private void MainButtonSair_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void MainProgressBar_progressChanged(object sender, EventArgs e)
        {

        }
    }
}
