using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee//intializes the Id property with 5
            {
                Id = 5
            };
            Employee emp2 = new Employee//intializes the Id property with 5
            {
                Id = 5
            };

            Console.WriteLine(emp1 == emp2);//calls overloaded == operator
            Console.Read();
            

        }
    }
}
