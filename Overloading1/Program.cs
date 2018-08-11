// 1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading1
{
    static class program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.name = "John Smith";
            employee2.name = "Jimbo Jenkins";

            employee1.ID = 1;
            employee2.ID = 1;

            if (employee1 == employee2)  Console.WriteLine("employee1 and 2 are equal ");

            else Console.WriteLine("employee1 and 2 are NOT equal ");


            Console.ReadLine();
        }
    }
}
