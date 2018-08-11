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
    }

    public class Employee : Person
    {
        public int ID;
        public int n;
        public bool status = false;

        public static bool operator ==(Employee iD1, Employee iD2)
        {
            if (iD1.ID == iD2.ID) return true;
            else return false;
        }
        public static bool operator !=(Employee iD1, Employee iD2)
        {
            if (iD1.ID != iD2.ID) return true;
            else return false;
        }
    }
}
