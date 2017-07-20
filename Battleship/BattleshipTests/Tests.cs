using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipGame.Models.Boards;
using BattleshipGame.Models.Ships;
using BattleshipGame.Enums;
using BattleshipGame.Models;
using System.Linq;

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

        [TestMethod]
        public void RandomFreeSpaceIsNotNull()
        {
            var sut = new GameBoard();
            var space = sut.GetRandomFreeSquare();

            Assert.IsNotNull(space.Coordinates.X);
            Assert.IsNotNull(space.Coordinates.Y);
        }

        [TestMethod]
        public void FindAllHorizontalFreeSpaces()
        {
            var sut = new GameBoard();

            var carrierFreeRanges = sut.GetAllFreeRandomHorizontalRanges(new Carrier().Size);
            var battleshipFreeRanges = sut.GetAllFreeRandomHorizontalRanges(new Battleship().Size);
            var cruiserFreeRanges = sut.GetAllFreeRandomHorizontalRanges(new Cruiser().Size);
            var destroyerFreeRanges = sut.GetAllFreeRandomHorizontalRanges(new Destroyer().Size);

            Assert.AreEqual(carrierFreeRanges.Count(), 60);
            Assert.AreEqual(battleshipFreeRanges.Count(), 70);
            Assert.AreEqual(cruiserFreeRanges.Count(), 80);
            Assert.AreEqual(destroyerFreeRanges.Count(), 90);
        }
    }
}
