using TK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            Assert.AreEqual(Program.Grade(15), 2);
            Assert.AreEqual(Program.Grade(100), -1);

            Assert.IsTrue(Program.FirstIsCorrect(0));
            Assert.IsFalse(Program.FirstIsCorrect(23));
            Assert.IsFalse(Program.FirstIsCorrect(-1));

            Assert.IsTrue(Program.SecondIsCorrect(5));
            Assert.IsFalse(Program.SecondIsCorrect(40));
            Assert.IsFalse(Program.SecondIsCorrect(-1));

            Assert.IsTrue(Program.ThirdIsCorrect(15));
            Assert.IsFalse(Program.ThirdIsCorrect(40));
            Assert.IsFalse(Program.ThirdIsCorrect(-1));
        }
    }
}
