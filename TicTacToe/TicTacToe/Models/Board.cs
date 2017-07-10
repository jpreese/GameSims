using System.Collections.Generic;

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

        public List<Space> GetFreeSpaces()
        {
            var freeSpaces = new List<Space>();

            for (int x = 0; x < BOARD_SIZE; x++)
            {
                if(Spaces[x].OccupiedBy == OccupationType.Empty)
                {
                    freeSpaces.Add(Spaces[x]);
                }
            }

            return freeSpaces;
        }
    }
}
