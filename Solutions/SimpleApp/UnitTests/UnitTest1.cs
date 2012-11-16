using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleApp;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(8, SimpleMath.Add(1, 7));
        }
    }
}
