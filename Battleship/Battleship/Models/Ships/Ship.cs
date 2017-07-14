using Battleship.Enums;

namespace Battleship.Models.Ships
{
    public abstract class Ship
    {
        public abstract OccupationType OccupationType { get; protected set; }
        public abstract int Size { get; protected set; }

        public int Hits { get; set; }

        public bool IsSunk()
        {
            return Hits >= Size;
        }
    }
}
