using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;

namespace ImagemMonocromatica
{
    class Player : SerialPort
    {
        public string PlayerID { get; set; }
        public string OpponentID { get; set; }
        public Bitmap PlayerImage { get; set; }
        public Bitmap OpponentImage { get; set; }
        public char PlayerLetter { get; set; }
        public char OpponentLetter { get; set; }
        public int PlayerValue { get; set; }
        public int OpponentValue { get; set; }
        public int PlayerWinValue { get; set; }
        public int OpponentWinValue { get; set; }
        public int NumberOfPlays;
        public bool Turn;
        public char Winner { get; set; }

        public Player()
        {
            PlayerID = Process.GetCurrentProcess().Id.ToString();
            NumberOfPlays = 0;
        }

        public void SetPlayer(string OpponentID_P, char PlayerImage_P, char OpponentImage_P, char PlayerLetter_P, char OpponetLetter_P, int PlayerValue_P, int OpponentValue_P, bool Turn_P)
        {
            string ResourcesPath = Directory.GetCurrentDirectory().Replace("bin\\Debug", "Resources");

            OpponentID = OpponentID_P;
            PlayerImage = new Bitmap($"{ResourcesPath}\\{PlayerImage_P}.png");
            OpponentImage = new Bitmap($"{ResourcesPath}\\{OpponentImage_P}.png");
            PlayerLetter = PlayerLetter_P;
            OpponentLetter = OpponetLetter_P;
            PlayerValue = PlayerValue_P;
            OpponentValue = OpponentValue_P;
            PlayerWinValue = 3 * PlayerValue;
            OpponentWinValue = 3 * OpponentValue;
            Turn = Turn_P;
        }

        public void ChangeTurn()
        {
            Turn = !Turn;
        }

        public Player GetPlayerByLetter(char Letter_P)
        {
            if (PlayerLetter == Letter_P) return this;
            else return null;
        }

        public new string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        public void ResetChangePlayer()
        {
            char AuxLetter;
            Bitmap AuxImage;
            int AuxPlayerValue, AuxWinValue;

            AuxLetter = PlayerLetter;
            PlayerLetter = OpponentLetter;
            OpponentLetter = AuxLetter;

            AuxImage = PlayerImage;
            PlayerImage = OpponentImage;
            OpponentImage = AuxImage;

            AuxPlayerValue = PlayerValue;
            PlayerValue = OpponentValue;
            OpponentValue = AuxPlayerValue;

            AuxWinValue = PlayerWinValue;
            PlayerWinValue = OpponentWinValue;
            OpponentWinValue = AuxWinValue;

            NumberOfPlays = 0;
            Winner = new char();
            //DiscardInBuffer();
            //DiscardOutBuffer();
        }
    }
}
