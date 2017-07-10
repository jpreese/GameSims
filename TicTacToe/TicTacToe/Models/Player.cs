using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe.Models
{
    public class Player
    {
        public readonly OccupationType Occupation;
        public List<Space> Moves;

        public Player(OccupationType occupation)
        {
            Occupation = occupation;
            Moves = new List<Space>();
        }

        public void TakeTurn(Board board)
        {
            var space = FindRandomFreeSpace(board);
            space.OccupiedBy = Occupation;

            Console.WriteLine(string.Format("{0} has chosen {1}", Occupation, space.Location));
        }

        private Space FindRandomFreeSpace(Board board)
        {
            var freeSpaces = board.GetFreeSpaces();

            var random = new Random();
            var randomSpaceIndex = random.Next(0, freeSpaces.Count);

            return freeSpaces.ElementAt(randomSpaceIndex);
        }
    }
}
