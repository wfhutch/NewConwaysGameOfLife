using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;
using System.Collections.Generic;

namespace ConwaysTests
{
    [TestClass]
    public class ConwaysGOLTests
    {

        [TestMethod]
        public void CanCreateInstanceOfGrid()
        {
            Grid MyGrid = new Grid();
            Assert.IsNotNull(MyGrid);
        }

        [TestMethod]
        public void StillLifeTestSquare()
        {
            bool[,] stillLife = new bool[,] { { true, true }, { true, true } };
            Grid board = new Grid(stillLife);
            board.Tick();
            CollectionAssert.AreEqual(stillLife, board.getBoard());
        }

        [TestMethod]
        public void StillLifeTestBeehive()
        {
            bool[,] beehive = new bool[,] { { false, true, true, false }, { true, false, false, true }, { false, true, true, false } };
            Grid board = new Grid(beehive);
            board.Tick();
            CollectionAssert.AreEqual(beehive, board.getBoard());
        }

        [TestMethod]
        public void OscillatorTest1()
        {
            bool[,] oscillator = new bool[,] { { false, true, false }, { false, true, false }, { false, true, false } };
            Grid board = new Grid(oscillator);
            board.Tick();
            bool[,] expected = new bool[,] { { false, false, false }, { true, true, true }, { false, false, false } };
            CollectionAssert.AreEqual(expected, board.getBoard());
        }

        [TestMethod]
        public void DiagonalTest1()
        {
            bool[,] diagonal = new bool[,] { { true, false, false }, { false, true, false }, { false, false, true } };
            Grid board = new Grid(diagonal);
            board.Tick();
            bool[,] expected = new bool[,] { { false, false, false }, { false, true, false }, { false, false, false } };
            CollectionAssert.AreEqual(expected, board.getBoard());
        }

        [TestMethod]
        public void BeaconTest1()
        {
            bool[,] beacon = new bool[,] { { true, true, false, false }, { true, true, false, false }, { false, false, true, true }, { false, false, true, true } };
            Grid board = new Grid(beacon);
            board.Tick();
            bool[,] expected = new bool[,] { { true, true, false, false }, { true, false, false, false }, { false, false, false, true }, { false, false, true, true } };
            CollectionAssert.AreEqual(expected, board.getBoard());
        }

        [TestMethod]
        public void ToadTest1()
        {
            bool[,] toad = new bool[,] { { false, false, false, false }, {false, true, true, true}, { true, true, true, false }, { false, false, false, false } };
            Grid board = new Grid(toad);
            board.Tick();
            bool[,] expected = new bool[,] { { false, false, true, false }, { true, false, false, true }, { true, false, false, true }, { false, true, false, false } };
            CollectionAssert.AreEqual(expected, board.getBoard());
        }
    }
}

