using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }

    public class EquipmentTypeList : List<EquipmentType>
    {

    }
}

