using System;
using System.Collections.Generic;
using System.Linq;

namespace MattSnowWTW
{
    public class TicTacToe
    {
        public TicTacToe(int n)
        {
            size = n;
            board = new char[size, size];
        }

        public int PlacePiece(int row, int col, int player)
        {
            var symbol = players[player - 1];
            board[row, col] = symbol;
            PrintBoard();
            if (IsGameOver())
            {
                return player;
            }
            else
            {
                return 0;
            }
        }

        void PrintBoard()
        {
            for (int y = 0; y < size; ++y)
            {
                for (int x = 0; x < size; ++x)
                {
                    Console.Write(board[y, x]);
                    if (x < size - 1)
                    {
                        Console.Write('|');
                    }
                }
                Console.Write('\n');
            }
        }


        bool IsGameOver()
        {
            return new[] { Columns(), Rows(), Diagonals() }.Any(
                lineOrientation => lineOrientation.Any(
                    line => players.Any(
                        player => line.All(
                            square => square == player))));
        }


        public IEnumerable<char[]> Rows()
        {
            for (int i = 0; i < size; ++i)
            {
                var row = new char[size];
                for (int j = 0; j < size; ++j)
                {
                    row[j] = board[i, j];
                }
                yield return row;
            }
        }

        public IEnumerable<char[]> Columns()
        {
            for (int i = 0; i < size; ++i)
            {
                var column = new char[size];
                for (int j = 0; j < size; ++j)
                {
                    column[j] = board[j, i];
                }
                yield return column;
            }
        }

        public IEnumerable<char[]> Diagonals()
        {
            var leftDiagonal = new char[size];
            var rightDiagonal = new char[size];
            for (int i = 0; i < size; ++i)
            {
                leftDiagonal[i] = board[i, i];
                rightDiagonal[i] = board[i, (size - 1) - i];
            }
            yield return leftDiagonal;
            yield return rightDiagonal;
        }

        private char[,] board;
        private static char[] players = new[] { 'X', 'O' };
        private int size;
    }

}