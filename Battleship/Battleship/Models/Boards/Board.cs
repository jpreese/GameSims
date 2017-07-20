using System.Collections.Generic;
using System.Linq;
using System;

using BattleshipGame.Enums;

namespace BattleshipGame.Models.Boards
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

        public Square GetRandomFreeSquare()
        {
            var freeSquares = Squares.Where(s => s.OccupationType == OccupationType.Empty);

            var random = new Random();
            var randomFreeIndex = random.Next(0, freeSquares.Count());

            return freeSquares.ElementAt(randomFreeIndex);
        }

        public List<IEnumerable<Square>> GetAllFreeRandomRanges(int rangeSize)
        {
            return FindAllFreeHorizontalRanges(rangeSize);
        }

        private List<IEnumerable<Square>> FindAllFreeHorizontalRanges(int rangeSize)
        {
            var ranges = new List<IEnumerable<Square>>();

            for(int x = 0; x <= Squares.Count - rangeSize; x++)
            {
                var currentRange = Squares.GetRange(x, rangeSize).Where(s => s.OccupationType == OccupationType.Empty && (Squares[x].Coordinates.Y + rangeSize) <= BOARD_SIZE);
                if(currentRange.Count() == rangeSize)
                {
                    ranges.Add(currentRange);
                }
            }

            return ranges;
        }
    }
}
