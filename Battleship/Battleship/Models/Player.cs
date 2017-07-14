using BattleshipGame.Models.Ships;
using BattleshipGame.Models.Boards;
using System.Collections.Generic;
using System.Linq;

namespace BattleshipGame.Models
{
    public class Player
    {
        public readonly List<Ship> Ships;
        public readonly GameBoard GameBoard;
        public readonly FiringBoard FiringBoard;

        public Player()
        {
            Ships = GetShips();

            GameBoard = new GameBoard();
            FiringBoard = new FiringBoard();
        }

        public bool HasLost()
        {
            return Ships.All(s => s.IsSunk());
        }

        private List<Ship> GetShips()
        {
            var ships = new List<Ship>();
            ships.Add(new Carrier());
            ships.Add(new Battleship());
            ships.Add(new Submarine());
            ships.Add(new Cruiser());
            ships.Add(new Destroyer());

            return ships;
        }
    }
}
