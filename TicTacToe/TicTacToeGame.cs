using System;

namespace TicTacToe
{
    public static class TicTacToeGame
    {
        // Declared Board of size 10. Ignoring 0 for user friendly App
        private static char[] board = new char[10];

        /// <summary>
        /// Initializes the <see cref="TicTacToeGame"/> class.
        /// </summary>
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
