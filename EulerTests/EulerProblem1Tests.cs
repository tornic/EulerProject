using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EulerProject.EulerProblems;

namespace EulerTests
{
    [TestClass]
    public class EulerProblem1Tests
    {
        [TestMethod]
        public void EulerProblem1FinalAnswer()
        {
            Assert.AreEqual(233168, EulerProblem1.solve());

        }
    }
}
