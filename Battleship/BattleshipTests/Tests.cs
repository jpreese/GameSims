using Microsoft.VisualStudio.TestTools.UnitTesting;
using Battleship.Models.Boards;
using Battleship.Models.Ships;
using Battleship.Enums;

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
        public void NewCarrierShipHasCorrectDefaults()
        {
            var sut = new Carrier();

            Assert.AreEqual(sut.OccupationType, OccupationType.Carrier);
            Assert.AreEqual(sut.Size, 5);
        }
    }
}
