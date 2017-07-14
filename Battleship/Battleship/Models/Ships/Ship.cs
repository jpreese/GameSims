using BattleshipGame.Enums;

namespace BattleshipGame.Models.Ships
{
    public abstract class Ship
    {
        public abstract OccupationType OccupationType { get; protected set; }
        public abstract int Size { get; protected set; }

        private int _hits;

        public void AddHit()
        {
            _hits++;
        }

        public bool IsSunk()
        {
            return _hits >= Size;
        }
    }
}
