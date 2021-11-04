using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParaAssignment
{
    class Class1
    {
        public static void MethodIncrement(int num, int addBy = 1)
        {
            for (int i= 0; i < 50; i++)
            {
                Console.WriteLine(num += addBy);
            }
        }

    }
}
