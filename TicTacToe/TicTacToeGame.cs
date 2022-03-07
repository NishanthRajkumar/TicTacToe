using System;

namespace TicTacToe
{
    public static class TicTacToeGame
    {
        private static char[] board = new char[10];

        static TicTacToeGame()
        {
            Array.Fill(board, ' ');
        }

        public static void DisplayBoard()
        {
            for (int i = 1; i < board.Length; i++)
            {
                Console.Write(board[i] + " ");
                if (i % 3 == 0)
                    Console.WriteLine();
            }
        }
    }
}
