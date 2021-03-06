using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RR_Game_Project.classes;

namespace RR_Game_UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        gamePlay myGamePlay = new gamePlay();
        [TestMethod]
        public void TestMethod1()
        {
            int Num = myGamePlay.RndNumber();
            Assert.IsTrue(Num > 0);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int Num = myGamePlay.RndNumber();
            Assert.IsTrue(Num < 7);
        }
    }
}
