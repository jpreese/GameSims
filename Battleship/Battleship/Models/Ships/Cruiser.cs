using BattleshipGame.Enums;

namespace BattleshipGame.Models.Ships
{
    public class Cruiser : Ship
    {
        public override OccupationType OccupationType { get; protected set; }
        public override int Size { get; protected set; }

        public Cruiser()
        {
            OccupationType = OccupationType.Cruiser;
            Size = 3;
        }
    }
}
