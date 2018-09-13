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
            ResetBoard();
        }

        public void ResetBoard()
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

                if (CheckWinner() && NumberPlays > 3)
                {
                    Console.WriteLine($"Jogador: {value} venceu!!!");
                    ResetBoard();
                    return;
                }

                LastPlayer = value;
                NumberPlays++;
            }
        }

        private bool CheckWinner()
        {
            char LastRow, LastColumn, LastMainDiagonal, LastSecondaryDiagonal;
            int ContRow, ContColumn, ContMainDiagonal, ContSecondaryDiagonal;
            int BoardSize = Board.GetLength(0) - 1;


            for (int i = 0; i <= BoardSize; i++)
            {
                ContRow = ContColumn = ContMainDiagonal = ContSecondaryDiagonal = 1;
                LastSecondaryDiagonal = Board[0, BoardSize];
                LastMainDiagonal = Board[0, 0];
                LastColumn = Board[0, i];
                LastRow = Board[i, 0];

                for (int j = 1; j <= BoardSize; j++)
                {
                    if (Board[j, BoardSize - j] == LastSecondaryDiagonal) ContSecondaryDiagonal++;
                    if (Board[j, j] == LastMainDiagonal) ContMainDiagonal++;
                    if (Board[j, i] == LastColumn) ContColumn++;
                    if (Board[i, j] == LastRow) ContRow++;                    
                }

                Console.WriteLine($"Linha: {ContRow} Coluna: {ContColumn} Principal: {ContMainDiagonal} Secundaria: {ContSecondaryDiagonal}");

                if (ContRow == BoardSize || ContColumn == BoardSize || ContMainDiagonal == BoardSize || ContSecondaryDiagonal == BoardSize) return true;
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
