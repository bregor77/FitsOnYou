using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestEx0;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DemoTest obj = new DemoTest();
            Assert.AreEqual("Mariusz", obj.fname);
            Assert.AreEqual("Kucharski", obj.lname);
        }
    }
}
