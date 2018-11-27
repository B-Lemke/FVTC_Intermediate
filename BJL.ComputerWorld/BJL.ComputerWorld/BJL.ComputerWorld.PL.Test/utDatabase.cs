using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BJL.ComputerWorld.PL;

namespace BJL.ComputerWorld.PL.Test
{
    [TestClass]
    public class utDatabase
    {
        [TestMethod]
        public void TestMethod1()
        {
            string connstr = Properties.Settings.Default.ConnStr;
        }
    }
}
