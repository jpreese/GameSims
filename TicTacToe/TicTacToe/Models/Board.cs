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

        public bool HasWinner()
        {
            if (CheckRowConditions())
            {
                return true;
            }

            if (CheckColumnConditions())
            {
                return true;
            }

            if (CheckDiagonalConditions())
            {
                return true;
            }

            return false;
        }
        private bool CheckRowConditions()
        {
            for (int x = 0; x <= 6; x += 3)
            {
                if (AllSpacesOwnedByPlayer(Spaces[x], Spaces[x + 1], Spaces[x + 2]))
                {
                    return true;
                }
            }

            return false;
        }

        private bool CheckColumnConditions()
        {
            for (int x = 0; x < 3; x++)
            {
                if (AllSpacesOwnedByPlayer(Spaces[x], Spaces[x + 3], Spaces[x + 6]))
                {
                    return true;
                }
            }

            return false;
        }

        private bool CheckDiagonalConditions()
        {
            if (AllSpacesOwnedByPlayer(Spaces[0], Spaces[4], Spaces[8]))
            {
                return true;
            }

            if (AllSpacesOwnedByPlayer(Spaces[2], Spaces[4], Spaces[6]))
            {
                return true;
            }

            return false;
        }

        private bool AllSpacesOwnedByPlayer(Space A, Space B, Space C)
        {
            return (A.OccupiedBy == B.OccupiedBy && B.OccupiedBy == C.OccupiedBy) && A.OccupiedBy != OccupationType.Empty;
        }

        private List<Space> GetFreeSpaces()
        {
            return Spaces.Where(s => s.OccupiedBy == OccupationType.Empty).ToList();
        }
    }
}
