using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BJL.ComputerWorld.PL;
using System.Data.SqlClient;
using System.Data;

namespace BJL.ComputerWorld.PL.Test
{
    [TestClass]
    public class utDatabase
    {
        [TestMethod]
        public void SoftwareLoadTest()
        {
            //setup
            const int expectedRowCount = 4;
            string connstr = Properties.Settings.Default.ConnStr;

            Database db = new Database(connstr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM tblSoftware";

            DataTable softwareList = new DataTable();

            

            //act
            softwareList = db.Select(cmd);
            int actualRowCount = softwareList.Rows.Count;


            //resolve
            Assert.AreEqual(expectedRowCount, actualRowCount);
            Assert.IsNotNull(softwareList);
        }
    }
}
