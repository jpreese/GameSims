using System;

namespace TicTacToe.Models
{
    public class Game
    {
        private Player currentPlayer;
        private readonly Player playerX;
        private readonly Player playerO;

        private readonly Board board;

        public Game()
        {
            board = new Board();

            playerX = new Player(OccupationType.X);
            playerO = new Player(OccupationType.O);

            currentPlayer = playerX;
        }

        public void StartGame()
        {
            while(true)
            {
                currentPlayer.TakeTurn(board);

                if(currentPlayer.HasWon(board))
                {
                    Console.WriteLine(string.Format("{0} has won.", currentPlayer.Occupation));
                    break;
                }

                if(board.IsFull())
                {
                    Console.WriteLine("Draw.");
                    break;
                }

                ChangePlayer();
            }
        }

        private void ChangePlayer()
        {
            if(currentPlayer == playerX)
            {
                currentPlayer = playerO;
            }
            else
            {
                currentPlayer = playerX;
            }
        }

    }
}
