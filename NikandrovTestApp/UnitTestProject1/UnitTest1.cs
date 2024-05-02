using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCorrectPassword()
        {
            string login = "john";
            string pass = "1";
            bool expected = true;

            bool actual = NikandrovTestApp.DBase.auth(login, pass);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodIncorrectPassword()
        {
            string login = "john";
            string pass = "2";
            bool expected = false;

            bool actual = NikandrovTestApp.DBase.auth(login, pass);
            Assert.AreEqual(expected, actual);
        }
    }
}
