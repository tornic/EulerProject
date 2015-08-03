using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EulerProject.EulerProblems;

namespace EulerTests
{
    [TestClass]
    public class EulerProblem3Tests
    {
        [TestMethod]
        public void EulerProblem3FinalAnswer()
        {
            Assert.AreEqual(6857, EulerProblem3.solve());

        }
    }
}
