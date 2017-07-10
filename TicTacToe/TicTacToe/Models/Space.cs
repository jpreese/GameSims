namespace TicTacToe.Models
{
    public class Space
    {
        public OccupationType OccupiedBy { get; set; } = OccupationType.Empty;
        public int Location { get; private set; }

        public Space(int location)
        {
            Location = location;
        }
    }
}
