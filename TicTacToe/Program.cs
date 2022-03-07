using System;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Tic Tac Toe==========");

            TicTacToeGame.PlayerChoice();
            TicTacToeGame.DisplayBoard();

            Console.ReadKey();
        }
    }
}
