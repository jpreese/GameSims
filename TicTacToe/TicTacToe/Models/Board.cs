using System.Collections.Generic;
using System.Linq;
using System;

namespace TicTacToe.Models
{
    public class Board
    {
        private const int BOARD_SIZE = 9;
        public readonly Space[] Spaces;

        public Board()
        {
            Spaces = new Space[BOARD_SIZE];

            for (int x = 0; x < BOARD_SIZE; x++)
            {
                Spaces[x] = new Space(x);
            }
        }

        public bool IsFull()
        {
            return GetFreeSpaces().Count == 0;
        }

        public Space GetRandomFreeSpace()
        {
            var freeSpaces = GetFreeSpaces();

            var random = new Random();
            var randomSpaceIndex = random.Next(0, freeSpaces.Count);

            return freeSpaces.ElementAt(randomSpaceIndex);
        }

        private List<Space> GetFreeSpaces()
        {
            return Spaces.Where(s => s.OccupiedBy == OccupationType.Empty).ToList();
        }
    }
}
