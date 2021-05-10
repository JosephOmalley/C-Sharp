using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects_Assignment
{
    public class Employee : Person
    {
        public int Id { get; set; }//instatiate Employee class int property Id

        public static bool operator ==(Employee emp1, Employee emp2)//this overload the boolean operator == so that it can handle the datatypes  
        {
            return emp1.Id == emp2.Id;
        }
        public static bool operator !=(Employee emp1, Employee emp2)//deals with the inverse of ==
        {
            return emp1.Id != emp2.Id;
        }
    }
}

