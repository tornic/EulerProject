using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EulerProject.EulerProjectMath;
using EulerProject.EulerProblems;

namespace EulerTests
{
    [TestClass]
    public class numberToLettersTest
    {
        [TestMethod]
        public void DisplayTheWordAnd()
        {
            Assert.AreEqual("and", numberToLetters.And(101));
            Assert.AreEqual("and", numberToLetters.And(151));
            Assert.AreEqual("and", numberToLetters.And(544));
        }

        [TestMethod]
        public void DoNotDisplayTheWordAnd()
        {
            Assert.AreEqual("", numberToLetters.And(100));
            Assert.AreEqual("", numberToLetters.And(200));
            Assert.AreEqual("", numberToLetters.And(300));
            Assert.AreEqual("", numberToLetters.And(400));
            Assert.AreEqual("", numberToLetters.And(500));
            Assert.AreEqual("", numberToLetters.And(600));
            Assert.AreEqual("", numberToLetters.And(700));
            Assert.AreEqual("", numberToLetters.And(800));
            Assert.AreEqual("", numberToLetters.And(900));
        }
    }
}
