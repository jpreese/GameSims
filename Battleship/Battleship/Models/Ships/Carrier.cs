using Battleship.Enums;

namespace Battleship.Models.Ships
{
    public sealed class Carrier : Ship
    {
        public override OccupationType OccupationType { get; protected set; }
        public override int Size { get; protected set; }

        public Carrier()
        {
            OccupationType = OccupationType.Carrier;
            Size = 5;
        }
    }
}
