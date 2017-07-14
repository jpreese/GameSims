using Battleship.Enums;

namespace Battleship.Models.Ships
{
    public class Destroyer : Ship
    {
        public override OccupationType OccupationType { get; protected set; }
        public override int Size { get; protected set; }

        public Destroyer()
        {
            OccupationType = OccupationType.Destroyer;
            Size = 2;
        }
    }
}
