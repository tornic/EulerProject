using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EulerProject.EulerProblems;

namespace EulerTests
{
    [TestClass]
    public class EulerProblem5Tests
    {
        [TestMethod]
        public void EulerProblem5FinalAnswer()
        {
            Assert.AreEqual(232792560, EulerProblem5.solve());

        }
    }
}
