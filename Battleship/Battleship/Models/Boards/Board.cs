using System.Collections.Generic;

namespace Battleship.Models.Boards
{
    public abstract class Board
    {
        public readonly List<Square> Squares;
        private const int BOARD_SIZE = 10;

        public Board()
        {
            Squares = new List<Square>();

            for (int x = 0; x < BOARD_SIZE; x++)
            {
                for (int y = 0; y < BOARD_SIZE; y++)
                {
                    Squares.Add(new Square(new Coordinates(x, y)));
                }
            }
        }
    }
}
