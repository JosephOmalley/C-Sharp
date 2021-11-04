using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    static class Class1
    {
        public static void MethodHalf(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine(result );
        }
        public static void MethodHalf(string num1)
        {
            int result = Convert.ToInt32(num1) / 2;
            Console.WriteLine(result);
        }
        public static void noParaMethod()
        {
            Console.WriteLine("This method takes in no parameters");
        }
    }
}
