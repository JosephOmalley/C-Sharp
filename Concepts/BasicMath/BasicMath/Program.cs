using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    class Program
    {
        static void Main()
        {
            //takes in number as a string and explictly converts it to a int
            Console.WriteLine("Enter a number to be multiplied by 50");
            string mInp = Console.ReadLine();
            int mRes = Convert.ToInt32(mInp) * 50;
            Console.WriteLine(mRes);

            //takes in number as a string and explictly converts it to a int 
            Console.WriteLine("Enter a number to be added by 25");
            string aInp = Console.ReadLine();
            int aRes = Convert.ToInt32(aInp) + 25;
            Console.WriteLine(aRes);
            //takes in number as a string and explictly converts it to a int then the result's set type is a double
            Console.WriteLine("Enter a number to be be divided by 12.5");
            string dInp = Console.ReadLine();
            double dRes = Convert.ToInt32(dInp)/12.5;
            Console.WriteLine(dRes);

            //takes in number as a string and explictly converts it to a int
            Console.WriteLine("Enter a number to be check if it's greater than 50");
            string cInp = Console.ReadLine();
            bool cRes = Convert.ToInt32(cInp) > 50;
            Console.WriteLine(cRes);

            Console.WriteLine("Enter a number to find the remainder of it when divide by 7");
            string rInp = Console.ReadLine();
            int rRes = Convert.ToInt32(rInp) % 7;
            Console.WriteLine(rRes);
            Console.Read();

        }
    }
}
