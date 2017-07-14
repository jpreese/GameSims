using System;
using BattleshipGame.Enums;

namespace BattleshipGame.Models.Ships
{
    public class Submarine : Ship
    {
        public override OccupationType OccupationType { get; protected set; }
        public override int Size { get; protected set; }

        public Submarine()
        {
            OccupationType = OccupationType.Submarine;
            Size = 3;
        }
    }
}
