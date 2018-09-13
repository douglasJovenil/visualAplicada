using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadaObjetos
{
    class Hash
    {
        private char[,] Board = new char[3, 3];
        public int NumberPlays { get; set; }
        private char LastPlayer;

        public Hash()
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++) Board[i, j] = '-';
            }

            NumberPlays = 0;
            LastPlayer = '-';
        }

        public void SetBoard(char value, int row, int column)
        {
            if (LastPlayer == value) Console.WriteLine("Você já jogou!");
            else if (row < 0 || row > 3 || column < 0 || column > 3) Console.WriteLine("Posição inválida!");
            else if (Board[row, column] != '-') Console.WriteLine("Posição já está preenchida!");
            else if (value != 'x' && value != 'o') Console.WriteLine("Jogada inválida!");
            else
            {
                Board[row, column] = value;
                if (CheckWinner())
                {
                    Console.WriteLine($"Jogador: {value} venceu!!!");
                    Console.ReadKey();
                }
                LastPlayer = value;
                NumberPlays++;
            }
        }

        private bool CheckWinner()
        {
            char LastPlay;
            int TmpCont;

            for (int i = 0; i < Board.GetLength(0); i++)
            {
                LastPlay = Board[i, 0];
                TmpCont = 1;
                for (int j = 1; j < Board.GetLength(1); j++)
                {
                    if (Board[i, j] == LastPlay) TmpCont++;
                }
                if (TmpCont == Board.GetLength(0))
                {
                    return true;
                }
            }
            return false;
        }

        public void GetBoard()
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write($"{Board[i, j]} ");
                }
                Console.WriteLine();
            }
        }


    }
}
