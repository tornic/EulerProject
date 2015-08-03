using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EulerProject.EulerProblems;

namespace EulerTests
{
    [TestClass]
    public class EulerProblem8Tests
    {
        [TestMethod]
        public void EulerProblem8FinalAnswer()
        {
            Assert.AreEqual(40824, EulerProblem8.solve());

        }
    }
}
