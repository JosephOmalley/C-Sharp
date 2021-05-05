using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class classwithmethod
    {
        public static void add2(int num)
        {
            int result = num + 2;
            Console.WriteLine(result);

        }
        public static void add2(double num)
        {
            double result = num + 2.00;
            Console.WriteLine(result);
        }
        public static void add2(string num)
        {
            string result = num + 2;
            Console.WriteLine(result);
        }



    }
}
