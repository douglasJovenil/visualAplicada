using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadaObjetos
{
    class Hash
    {
        private char[,] Board = new char[3, 3];
        public int NumberPlays { get; set; }

        public Hash()
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(0); j++) Board[i, j] = '-';
            }

            NumberPlays = 0;
        }

        public void SetBoard(char value, int row, int column)
        {
            if (row < 0 || row > 3 || column < 0 || column > 3) Console.WriteLine("Posição inválida!");
            else if (Board[row, column] != '-') Console.WriteLine("Posição já está preenchida!");
            else if (value != 'x' && value != 'o') Console.WriteLine("Jogada inválida!");
            else
            {
                Board[row, column] = value;
                NumberPlays++;
            }
        }

        public void GetBoard()
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(0); j++)
                {
                    Console.Write($"{Board[i, j]} ");
                }
                Console.WriteLine();
            }
        }


    }
}
