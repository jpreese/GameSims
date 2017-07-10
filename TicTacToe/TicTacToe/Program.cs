using System;
using TicTacToe.Models;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.StartGame();

            Console.ReadKey();
        }
    }
}
