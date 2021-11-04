using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_assignment
{
    class Program
    {
        public struct Number// create instance of struct "Number"
        {
            public decimal Amount; // 
        }
        static void Main(string[] args)
        {
            Number num1 = new Number();// instatiate it with object named num1 
            num1.Amount = 1.00m; //intailzed Property of struct Number with decimal 1

            Console.WriteLine(num1.Amount);//write num1 to console.
            Console.ReadLine();
        }
        

    }
}
