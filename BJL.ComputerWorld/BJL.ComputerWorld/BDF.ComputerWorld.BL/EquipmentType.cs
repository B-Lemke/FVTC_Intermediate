using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BJL.ComputerWorld.PL;

namespace BDF.ComputerWorld.BL
{
    public class EquipmentType
    {

        public enum Types
        {
            Desktop = 0,
            Laptop = 1,
            Server = 2,
            Tablet = 3
        }

        private Types id;

        public Types Id
        {
            get { return id; }
            set { id = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Contents
        {
            get
            {
                return ((int)id).ToString() + "|" + description;
            }
        }

    }

    public class EquipmentTypeList : List<EquipmentType>
    {
        public void SaveFile()
        {
            try
            {
                FileIO fileIO = new FileIO();
                fileIO.FileName = "EquipmentTypes.txt";

                fileIO.Delete();

                //Convert list ot string
                foreach(EquipmentType e in this)
                {
                    fileIO.Write(e.Contents);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Load()
        {
            try
            {
                FileIO fileIO = new FileIO();
                fileIO.FileName = "EquipmentTypes.txt";

                string contents = fileIO.Read();

                //Split the contents into a string array
                string[] arrayContents = contents.Split('\r');

                foreach (string row in arrayContents)
                {
                    //process each line
                    string[] etype = row.Split('|');

                    EquipmentType et = new EquipmentType();
                    et.Id = (EquipmentType.Types)Convert.ToInt32(etype[0]);
                    et.Description = etype[1];
                    Add(et);
                }

            }
            catch (Exception e)
            {

                throw e;
            }
        }

    }
}

