using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading1
{
    public class Person
    {
        public string name;
        public List<string> Names { get; set; }
        public List<string> IDS { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void SayName()
        {
            string firstName = "Sample", lastName = "Student";
            Console.WriteLine("Full name is: " + firstName + " " + lastName);
        }
    }

    public class Employee : Person
    {
        int ID;

        public static bool operator== (Employee iD1, Employee iD2)
        {
            bool status = false;
            if (iD1 == iD2)
            {

                status = true;
            }
            return status;
        }
        public static bool operator!= (Employee iD1, Employee iD2)
        {
            bool status = false;
            if (iD1 != iD2)
            {

                status = false;
            }
            return status;
        }
    }
}
