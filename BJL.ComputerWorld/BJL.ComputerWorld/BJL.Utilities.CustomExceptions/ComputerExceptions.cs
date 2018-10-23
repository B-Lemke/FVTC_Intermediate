using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJL.Utilities.CustomExceptions
{
    public class BadHardDriveException : Exception
    {
        public BadHardDriveException() : base("Bad Hard Drive size value.")
        {

        }

        public BadHardDriveException(string message) : base(message)
        {

        }
    }
}
