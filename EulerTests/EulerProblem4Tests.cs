using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EulerProject.EulerProblems;

namespace EulerTests
{
    [TestClass]
    public class EulerProblem4Tests
    {
        [TestMethod]
        public void EulerProblem4FinalAnswer()
        {
            Assert.AreEqual(906609, EulerProblem4.solve());

        }
    }
}
