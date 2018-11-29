using BJL.ComputerWorld.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDF.ComputerWorld.BL
{
    public class Software
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int size;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private int equipmentId;

        public int EquipmentID
        {
            get { return equipmentId; }
            set { equipmentId = value; }
        }

        public Software()
        {

        }

        public Software(int id,
                        string name,
                        string description,
                        double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

    }

    public class SoftwareList : List<Software>
    {
        public void Seed(int id)
        {
            if (id == 1)
            {
                Software software = new Software(1, "Word", "Microsoft Word", 9.99);
                this.Add(software);
            }
            else
            {
                Software software2 = new Software(2, "Fortnite", "Epic Fortnite", 19.99);
                this.Add(software2);

                Software software3 = new Software(3, "Counter-Strike", "Valve CS", 49.99);
                this.Add(software3);
            }
        }


        public void Load()
        {
            Database db = new Database(Properties.Settings.Default.ConnStr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM tblSoftware";

            DataTable softwares = new DataTable();
            softwares = db.Select(cmd);

            foreach(DataRow dr in softwares.Rows)
            {
                //Make software
                Software software = new Software();

                //Set properties
                software.Description = dr["Description"].ToString();
                software.Id = Convert.ToInt32(dr["Id"]);
                software.Name = dr["Name"].ToString();
                software.Price = Convert.ToDouble(dr["Price"]);
                software.Size = Convert.ToInt32(dr["Size"]);
                software.EquipmentID = Convert.ToInt32(dr["EquipmentID"]);

                //Add to the list
                this.Add(software);
            }

        }


    }
}
