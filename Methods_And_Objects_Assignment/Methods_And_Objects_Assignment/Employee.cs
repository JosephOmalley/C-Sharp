using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects_Assignment
{
    public class Employee : Person
    {
        
        public static  bool operator ==(Employee person, Employee person2)
        {
            return Convert.ToInt32(person) == Convert.ToInt32(person2);
        }
        public static bool operator !=(Employee person, Employee person2)
        {
            return Convert.ToInt32(person) != Convert.ToInt32(person2);
        }
    }
}
