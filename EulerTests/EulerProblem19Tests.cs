using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EulerProject.EulerProblems;

namespace EulerTests
{
    [TestClass]
    public class EulerProblem19Tests
    {
        [TestMethod]
        public void yearDivisibleByFourReturnsTrue()
        {
            Assert.AreEqual(true, EulerProblem19.isLeapYear(1904));
        }

        [TestMethod]
        public void yearNotDivisibleByFourReturnsFalse()
        {
            Assert.AreEqual(false, EulerProblem19.isLeapYear(1903));
        }

        [TestMethod]
        public void centuryNotDivisbleByFourHundredReturnsFalse()
        {
            Assert.AreEqual(false, EulerProblem19.isLeapYear(1900));
        }

        [TestMethod]
        public void centuryDivisibleByFourHundredReturnsTrue()
        {
            Assert.AreEqual(true, EulerProblem19.isLeapYear(2000));
        }
    }
}
