using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BDF.ComputerWorld.BL;

namespace BJL.ComputerWorld.BL.Test
{
    [TestClass]
    public class utComputer
    {
        [TestMethod]
        public void SeedTest()
        {
            ComputerList computerList = new ComputerList();
            computerList.Seed();

            //Test to see if I have two computers
            int expected = 2;
            int actual = computerList.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
