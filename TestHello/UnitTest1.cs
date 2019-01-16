using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinDemo;
namespace TestHello
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           Assert.AreEqual("Hello Jenkins! How are you?", Program.createMessage());
        }
    }
}
