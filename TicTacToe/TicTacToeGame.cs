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

        public static void Start()
        {
            do
            {
                DisplayBoard();

                Console.WriteLine($"Player 1 turn ({player1Character}):");
                PlayerInput(player1Character);

                DisplayBoard();

                if (WinCheck())
                    Console.WriteLine("Congratulations Player 1!");

                Console.WriteLine($"Player 2 turn ({player2Character}):");
                PlayerInput(player2Character);

            } while (WinCheck() is false);

            DisplayBoard();
            Console.WriteLine("Congratulations Player 2!");
        }

        public static bool WinCheck()
        {
            for (int i = 1; i < 9; i += 3)
                if (RowCheck(board[i], board[i + 1], board[i + 2]))
                    return true;
            for (int j = 1; j < 3; j++)
                if (RowCheck(board[j], board[j + 3], board[j + 6]))
                    return true;
            if (RowCheck(board[1], board[5], board[9]))
                return true;
            if (RowCheck(board[3], board[5], board[7]))
                return true;
            return false;
        }

        public static bool RowCheck(params char[] value)
        {
            if (value[0] == value[1] && value[1] == value[2] && value[0] != ' ')
                return true;
            return false;
        }

        public static void PlayerInput(char value)
        {
            int choice;
            try
            {
                do
                {
                    Console.Write("Player, choose position(1-9): ");
                    choice = Int32.Parse(Console.ReadLine());
                } while ((choice < 0 || choice > 9));
                if (board[choice] != ' ')
                {
                    Console.WriteLine("Position already filled");
                    PlayerInput(value);
                }
                else
                    board[choice] = value;
            }
            catch
            {
                Console.WriteLine("Must enter integer value only!");
            }
        }
    }
}
