using BattleshipGame.Enums;

namespace BattleshipGame.Models.Boards
{
    public class Square
    {
        public readonly Coordinates Coordinates;
        public OccupationType OccupationType { get; set; } = OccupationType.Empty;

        public Square(Coordinates coordinates)
        {
            Coordinates = coordinates;
        }
    }
}
