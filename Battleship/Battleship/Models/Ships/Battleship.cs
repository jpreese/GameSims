using Battleship.Enums;

namespace Battleship.Models.Ships
{
    public class Battleship : Ship
    {
        public override OccupationType OccupationType { get; protected set; }
        public override int Size { get; protected set; }

        public Battleship()
        {
            OccupationType = OccupationType.Battleship;
            Size = 4;
        }
    }
}
