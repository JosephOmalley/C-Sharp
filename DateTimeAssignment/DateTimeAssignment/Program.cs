using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a number to see what hour it\'ll be in that amount of time.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(x));//adds an a user determinded amount of hours
            Console.ReadLine();
        }
    }
}
