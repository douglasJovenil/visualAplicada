using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagemMonocromatica
{
    class Player : SerialPort
    {
        public string ID { get; set; }
        public Bitmap Image { get; set; }
        public char Letter { get; set; }
        public int Value { get; set; }
        public int NumberOfPlays;
        public bool MyTurn;

        public Player()
        {
            // string ResourcesPath = Directory.GetCurrentDirectory().Replace("bin\\Debug", "Resources"); // Usar pra carregar as imagens
            ID = Process.GetCurrentProcess().Id.ToString();
        }

        public Player(string ID_P)
        {
            ID = ID_P;
        }

        public Player GetPlayerByLetter(char Letter_P)
        {
            if (Letter == Letter_P) return this;
            else return null;
        }

        public Player GetPlayerByID(string ID_P)
        {
            if (ID == ID_P) return this;
            else return null;
        }

        public new string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }
    }
}
