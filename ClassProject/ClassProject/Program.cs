using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int uNum = Convert.ToInt32(Console.ReadLine());
            Class1.MethodHalf(uNum);
            Class1.noParaMethod();
            Console.WriteLine("Press enter key to exit");
            Console.ReadLine();
        }
    }
}
