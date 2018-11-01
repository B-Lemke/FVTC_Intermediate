using System;
using System.Collections.Generic;
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
        public void Seed()
        {
            Software software = new Software(1, "Word", "Microsoft Word", 9.99);
            this.Add(software);

            Software software2 = new Software(2, "Fortnite", "Epic Fortnite", 19.99);
            this.Add(software2);

            Software software3 = new Software(3, "Counter-Strike", "Valve CS", 49.99);
            this.Add(software3);

        }
    }
}
