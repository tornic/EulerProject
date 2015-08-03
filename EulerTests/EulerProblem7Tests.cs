using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EulerProject.EulerProblems;

namespace EulerTests
{
    [TestClass]
    public class EulerProblem7Tests
    {
        [TestMethod]
        public void EulerProblem7FinalAnswer()
        {
            Assert.AreEqual(104743, EulerProblem7.solve());

        }
    }
}
