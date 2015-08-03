using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EulerProject.EulerProblems;

namespace EulerTests
{
    [TestClass]
    public class EulerProblem2Tests
    {
        [TestMethod]
        public void EulerProblem2FinalAnswer()
        {
            Assert.AreEqual(4613732, EulerProblem2.solve());

        }
    }
}
