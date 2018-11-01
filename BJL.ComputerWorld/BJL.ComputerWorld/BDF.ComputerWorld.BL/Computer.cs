using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BJL.Utilities.CustomExceptions;

namespace BDF.ComputerWorld.BL
{
    public class Computer : Equipment
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
            computer1.EquipmentType = 2;

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
            computer2.EquipmentType = 3;

            this.Add(computer2);
        }
    }
}
