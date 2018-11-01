using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDF.ComputerWorld.BL
{
    public class Equipment
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string serialNo;

        public string SerialNo
        {
            get { return serialNo; }
            set { serialNo = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private EquipmentType.Types equipmentType;

        public EquipmentType.Types EquipmentType
        {
            get { return equipmentType; }
            set { equipmentType = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }


    }
}
