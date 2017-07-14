using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipGame.Models.Boards;
using BattleshipGame.Models.Ships;
using BattleshipGame.Enums;
using BattleshipGame.Models;

namespace BattleshipTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void BoardsInitializedWithSize100Array()
        {
            var gameBoard = new GameBoard();
            var firingBoard = new FiringBoard();

            Assert.AreEqual(gameBoard.Squares.Count, 100);
            Assert.AreEqual(firingBoard.Squares.Count, 100);
        }

        [TestMethod]
        public void NewShipHasCorrectDefaults()
        {
            var sut = new Carrier();

            Assert.AreEqual(sut.OccupationType, OccupationType.Carrier);
            Assert.AreEqual(sut.Size, 5);
        }

        [TestMethod]
        public void ShipCanBeSunk()
        {
            var sut = new Carrier();

            for(int x = 0; x < sut.Size; x++)
            {
                sut.AddHit();
            }

            Assert.IsTrue(sut.IsSunk());
        }

        [TestMethod]
        public void NewPlayerHasNotLost()
        {
            var sut = new Player();

            Assert.IsFalse(sut.HasLost());
        }
    }
}
