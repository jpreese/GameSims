using System;
using System.Linq;

namespace TicTacToe.Models
{
    public class Player
    {
        public readonly OccupationType Occupation;

        public Player(OccupationType occupation)
        {
            if(occupation == OccupationType.Empty)
            {
                throw new ArgumentException("A player cannot be an empty space.");
            }

            Occupation = occupation;
        }

        public void TakeTurn(Board board)
        {
            var space = board.GetRandomFreeSpace();
            space.OccupiedBy = Occupation;

            Console.WriteLine(string.Format("{0} has chosen {1}", Occupation, space.Location));
        }
    }
}
