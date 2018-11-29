using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BJL.Utilities.CustomExceptions;
using BJL.ComputerWorld.PL;
using System.Xml.Serialization;
using System.IO;
using BJL.ComputerWorld.Interface;
using System.Data.SqlClient;
using System.Data;

namespace BDF.ComputerWorld.BL
{

    public class Computer : Equipment, IComputer
    {
        private int hardDriveSize;

        public int HardDriveSize
        {
            get { return hardDriveSize; }
            set
            {
                if (value > 0)
                {
                    hardDriveSize = value;
                }
                else
                {
                    throw new BadHardDriveException(); //ex.Message = "Bad Hard Drive Size Value"

                    throw new BadHardDriveException("Inaccurate HD Size");
                }
            }
        }

        private int ram;

        public int RAM
        {
            get { return ram; }
            set { ram = value; }
        }

        private SoftwareList softwareList;

        public SoftwareList SoftwareList
        {
            get { return softwareList; }
            set { softwareList = value; }
        }

        public bool Insert()
        {
            throw new NotImplementedException();
        }

        public int Update(string userid)
        {
            throw new NotImplementedException();
        }
    }

    public class ComputerList : List<Computer>
    {

        /// <summary>
        /// Hard code a list of computers
        /// </summary>
        public void Seed()
        {
            Computer computer1;
            computer1 = new Computer();

            //Set the properties
            computer1.Id = 1;
            computer1.Manufacturer = "HP";
            computer1.Model = "6100";
            computer1.Price = 499.99;
            computer1.RAM = 16;
            computer1.HardDriveSize = 1024;
            computer1.SerialNo = "xxx-xx-xx1a";
            computer1.Description = "My shiny new computer";
            computer1.EquipmentType = EquipmentType.Types.Server;

            computer1.SoftwareList = new SoftwareList();
            computer1.SoftwareList.Seed(computer1.Id);

            this.Add(computer1);

            Computer computer2 = new Computer();
            //Set the properties
            computer2.Id = 2;
            computer2.Manufacturer = "Dell";
            computer2.Model = "3000";
            computer2.Price = 109.99;
            computer2.RAM = 4;
            computer2.HardDriveSize = 256;
            computer2.SerialNo = "xxx-xx-xx2b";
            computer2.Description = "Crappy small computer";
            computer2.EquipmentType = EquipmentType.Types.Tablet;


            computer2.SoftwareList = new SoftwareList();
            computer2.SoftwareList.Seed(computer2.Id);

            this.Add(computer2);
        }


        public void Load()
        {
            try
            {
                FileIO fileIO = new FileIO();

                //Set the file name
                fileIO.FileName = "computers.xml";

                XmlSerializer serializer = new XmlSerializer(typeof(List<Computer>));
                TextReader tr = new StreamReader(fileIO.FileName);
                this.AddRange((List<Computer>)serializer.Deserialize(tr));

                tr.Close();
                tr = null;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public void Save()
        {
            try
            {
                FileIO fileIO = new FileIO();

                //Set the file name
                fileIO.FileName = "computers.xml";

                //Delete the file if it exists
                fileIO.Delete();

                XmlSerializer serializer = new XmlSerializer(typeof(List<Computer>));
                TextWriter tw = new StreamWriter(fileIO.FileName);
                serializer.Serialize(tw, this);

                tw.Close();
                tw = null;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void Loaddb()
        {
            try
            {
                Database db = new Database(Properties.Settings.Default.ConnStr);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblEquipment";

                DataTable computers = new DataTable();
                
                //retrieve the data
                computers = db.Select(cmd);

                foreach(DataRow dr in computers.Rows)
                {
                    //Make a computer
                    Computer computer = new Computer();

                    //Set the property values of the computer from the data row
                    computer.Description = dr["Description"].ToString();
                    computer.Id = Convert.ToInt32(dr["Id"]);
                    computer.Manufacturer = dr["Manufacturer"].ToString();
                    computer.Model = dr["Model"].ToString();
                    computer.SerialNo = dr["SerialNo"].ToString();
                    computer.Price = Convert.ToDouble(dr["Price"]);
                    computer.EquipmentType = (EquipmentType.Types)(dr["EquipmentTypeID"]);

                    //add computer to the list
                    this.Add(computer);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }



}
