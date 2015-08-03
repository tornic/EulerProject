using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EulerProject.EulerProjectMath;
using EulerProject.EulerProblems;

namespace EulerTests
{
    [TestClass]
    public class NumberToLettersTests
    {
        [TestMethod]
        public void DisplayTheWordAnd()
        {
            Assert.AreEqual("and", NumberToLetters.And(101));
            Assert.AreEqual("and", NumberToLetters.And(151));
            Assert.AreEqual("and", NumberToLetters.And(544));
            Assert.AreEqual("and", NumberToLetters.And(102));
        }

        [TestMethod]
        public void DoNotDisplayTheWordAnd()
        {
            Assert.AreEqual("", NumberToLetters.And(100));
            Assert.AreEqual("", NumberToLetters.And(200));
            Assert.AreEqual("", NumberToLetters.And(300));
            Assert.AreEqual("", NumberToLetters.And(400));
            Assert.AreEqual("", NumberToLetters.And(500));
            Assert.AreEqual("", NumberToLetters.And(600));
            Assert.AreEqual("", NumberToLetters.And(700));
            Assert.AreEqual("", NumberToLetters.And(800));
            Assert.AreEqual("", NumberToLetters.And(900));
        }
    }
}
