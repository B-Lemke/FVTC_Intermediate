using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJL.ComputerWorld.Interface
{
    public interface IComputer
    {
        //Anything using this interface has to have all of the properties and methods present here
        int HardDriveSize { get; set; }

        bool Insert();

        int Update(string userid);
    }
}
