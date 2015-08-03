using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EulerProject.EulerProblems;

namespace EulerTests
{
    [TestClass]
    public class EulerProblem6Tests
    {
        [TestMethod]
        public void EulerProblem6FinalAnswer()
        {
            Assert.AreEqual(25164150, EulerProblem6.solve());

        }
    }
}
