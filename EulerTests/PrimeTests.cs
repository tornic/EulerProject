using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EulerProject.EulerProjectMath;
using EulerProject.EulerProblems;

namespace EulerTests
{
    [TestClass]
    public class PrimeTests
    {
        [TestMethod]
        public void IsNotAPrimeNumber()
        {            
            Assert.AreEqual(false, Prime.isPrime(4));
            Assert.AreEqual(false, Prime.isPrime(9));
            Assert.AreEqual(false, Prime.isPrime(15));
            Assert.AreEqual(false, Prime.isPrime(22));
        }

        [TestMethod]
        public void IsAPrimeNumber()
        {
            Assert.AreEqual(true, Prime.isPrime(2));
            Assert.AreEqual(true, Prime.isPrime(5));
            Assert.AreEqual(true, Prime.isPrime(1499));
            Assert.AreEqual(true, Prime.isPrime(2027));

        }
    }
}
