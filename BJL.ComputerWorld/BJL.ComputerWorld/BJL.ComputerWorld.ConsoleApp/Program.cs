using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDF.ComputerWorld.BL;


namespace BJL.ComputerWorld.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name + "!");
            Console.ReadLine();

            ComputerList computerList = new ComputerList();
            computerList.Seed();

            
            /*
            foreach (Computer comp in computerList)
            {
                Console.WriteLine(comp.Manufacturer + ":" + comp.Model);
            }
            */


            //Do same code as above with lambda expression
            computerList.ForEach(c => Console.WriteLine(c.Manufacturer + ":" + c.Model));

            Console.ReadLine();


        }
    }
}
