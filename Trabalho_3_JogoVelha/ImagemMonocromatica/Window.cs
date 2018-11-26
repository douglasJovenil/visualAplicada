using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagemMonocromatica
{
    class Window
    {

        private int MainFormPositionX;
        private int MainFormPositionY;
        private bool MainMoveForm;

        public Window(int HeightForm, int WidthForm)
        {
            MainFormPositionY = HeightForm / 2;
            MainFormPositionX = WidthForm / 2;
            MainMoveForm = false;
        }

        public void MouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainFormPositionX = e.X;
                MainFormPositionY = e.Y;
                MainMoveForm = true;
            }
        }

        public void MouseUp(MouseEventArgs e)
        {
            MainMoveForm = false;
        }

        public Point MouseMove(MouseEventArgs e, Point Location_P)
        {
            if (MainMoveForm) return new Point(e.X + Location_P.X - MainFormPositionX, e.Y + Location_P.Y - MainFormPositionY);
            else return Location_P;
        }
    }
}
