using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading1
{

// 1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

    static class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Employee employee = new Employee();
            employee.Names = new List<Names>();                   // <----------- Weird error here about system.collections

            employee.Names.Add("Joe Schmoe");
            employee.Names.Add("Pete Schmoe");
            employee.Names.Add("Rachel Schmoe");
            employee.Names.Add("Turkey Schmoe");

            employee.IDS.Add("1");
            employee.IDS.Add("2");
            employee.IDS.Add("3");
            employee.IDS.Add("1");

            // INSERT CODE TO COMPARE ID's HERE
            //
            // .....
            //
            //

            employee.SayName();

            

            Console.ReadLine();
        }
    }
}
