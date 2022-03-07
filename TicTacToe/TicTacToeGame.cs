using System;

namespace TicTacToe
{
    public static class TicTacToeGame
    {
        private static char player1Character;
        private static char player2Character;
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

        public static void PlayerChoice()
        {
            string choice;
            do
            {
                Console.Write("Player 1, Choose X or O: ");
                choice = Console.ReadLine();
            } while (choice != "X" && choice != "O");
            player1Character = choice.ToCharArray()[0];
            if (choice == "X")
                player2Character = 'O';
            else
                player2Character = 'X';
            Console.WriteLine($"Player 1 character: {player1Character}");
            Console.WriteLine($"Player 2 character: {player2Character}");
        }
    }
}
