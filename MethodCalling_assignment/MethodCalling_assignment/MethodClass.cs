using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCalling_assignment
{
    public class MethodClass
    {
        public static void AddMethod(int num) //since this method does not contain a return statement, but has writeline which returns a string it has static and void 
        {
            Console.WriteLine(num + 1);
        }
        public static void FindTip(int bill)
        {
            Console.WriteLine(bill * .20);
        }
        public static void doubleNum(int num)
        {
            Console.WriteLine(num * 2);
        }
    }
}
