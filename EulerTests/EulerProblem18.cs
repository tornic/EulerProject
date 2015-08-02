using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EulerProject.EulerProblems;

namespace EulerTests
{
    [TestClass]
    public class EulerProblem18Tests
    {
        #region getRowMaxPosition

        [TestMethod]
        public void RowMaxPositionEqualsRowPlusOne()
        {
            Assert.AreEqual(1, EulerProblem18.getRowMaxPosition(0));
            Assert.AreEqual(2, EulerProblem18.getRowMaxPosition(1));
            Assert.AreEqual(3, EulerProblem18.getRowMaxPosition(2));
        }

        #endregion

        #region isValidRowAndPosition

        [TestMethod]
        public void NegativePositionReturnsFalse()
        {
            Assert.AreEqual(false, EulerProblem18.isValidRowAndPosition(0, -1));
        }

        [TestMethod]
        public void NegativeRowReturnsFalse()
        {
            Assert.AreEqual(false, EulerProblem18.isValidRowAndPosition(-1, 0));
        }

        [TestMethod]
        public void PositionGreaterThanMaxPositionReturnsFalse()
        {
            int maxPosition = EulerProblem18.getRowMaxPosition(2);

            Assert.AreEqual(false, EulerProblem18.isValidRowAndPosition(2, maxPosition));
        }

        [TestMethod]
        public void ValidRowAndPositionReturnsTrue()
        {
            Assert.AreEqual(true, EulerProblem18.isValidRowAndPosition(0, 0));
        }

        #endregion

        #region getIndexOfElement

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void InvalidPositionThrowsException()
        {
            EulerProblem18.getIndexOfElement(0, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void InvalidRowThrowsException()
        {
            EulerProblem18.getIndexOfElement(-1, 0);
        }

        [TestMethod]
        public void IndexOfElementWithRowZeroEqualsZero()
        {
            Assert.AreEqual(0, EulerProblem18.getIndexOfElement(0, 0));
        }

        [TestMethod]
        public void IndexOfElementWithRowOneEqualOnePlusPosition()
        {
            Assert.AreEqual(1, EulerProblem18.getIndexOfElement(1, 0));
            Assert.AreEqual(2, EulerProblem18.getIndexOfElement(1, 1));
        }

        [TestMethod]
        public void IndexOfElementWithRowGreaterThanTwoReturnsRowPlusPreviousPlusPosition()
        {
            Assert.AreEqual(3, EulerProblem18.getIndexOfElement(2, 0));
            Assert.AreEqual(4, EulerProblem18.getIndexOfElement(2, 1));
            Assert.AreEqual(6, EulerProblem18.getIndexOfElement(3, 0));
            Assert.AreEqual(8, EulerProblem18.getIndexOfElement(3, 2));
            Assert.AreEqual(10, EulerProblem18.getIndexOfElement(4, 0));
        }

        #endregion

        #region arePositionsAdjacent

        [TestMethod]
        public void PositionsAreNotAdjacentIfSecondRowNotOneLarger()
        {
            Assert.AreEqual(false, EulerProblem18.arePositionsAdjacent(0, 0, 2, 0));
        }

        [TestMethod]
        public void PositionsAreAdjacentIfPositionsAreEqual()
        {
            Assert.AreEqual(true, EulerProblem18.arePositionsAdjacent(0, 0, 1, 0));
            Assert.AreEqual(true, EulerProblem18.arePositionsAdjacent(1, 0, 2, 0));
            Assert.AreEqual(true, EulerProblem18.arePositionsAdjacent(1, 1, 2, 1));
            Assert.AreEqual(true, EulerProblem18.arePositionsAdjacent(2, 0, 3, 0));
            Assert.AreEqual(true, EulerProblem18.arePositionsAdjacent(2, 1, 3, 1));
            Assert.AreEqual(true, EulerProblem18.arePositionsAdjacent(2, 2, 3, 2));
        }

        [TestMethod]
        public void PositionsAreAdjacentIfPosition1PlusOneEqualsPosition2()
        {
            Assert.AreEqual(true, EulerProblem18.arePositionsAdjacent(0, 0, 1, 1));
            Assert.AreEqual(true, EulerProblem18.arePositionsAdjacent(1, 0, 2, 1));
            Assert.AreEqual(true, EulerProblem18.arePositionsAdjacent(1, 1, 2, 2));
            Assert.AreEqual(true, EulerProblem18.arePositionsAdjacent(2, 0, 3, 1));
            Assert.AreEqual(true, EulerProblem18.arePositionsAdjacent(2, 1, 3, 2));
            Assert.AreEqual(true, EulerProblem18.arePositionsAdjacent(2, 2, 3, 3));
        }

        [TestMethod]
        public void PositionsAreNotAdjacentIfPosition2NotEqualToPosition1OrPosition1PlusOne()
        {
            Assert.AreEqual(false, EulerProblem18.arePositionsAdjacent(1, 0, 2, 2));
            Assert.AreEqual(false, EulerProblem18.arePositionsAdjacent(1, 1, 2, 0));
            Assert.AreEqual(false, EulerProblem18.arePositionsAdjacent(2, 0, 3, 2));
            Assert.AreEqual(false, EulerProblem18.arePositionsAdjacent(2, 0, 3, 3));
            Assert.AreEqual(false, EulerProblem18.arePositionsAdjacent(2, 2, 3, 0));
            Assert.AreEqual(false, EulerProblem18.arePositionsAdjacent(2, 2, 3, 1));
        }

        #endregion

        
    }
}
