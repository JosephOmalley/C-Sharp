using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CompareIncome
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Anonymous Income Comparison Program");
            //Gets employee one's info
            Console.WriteLine("Enter first employee's hourly pay rate:");
            string emp1Pay = Console.ReadLine();
            Console.WriteLine("Enter their hours worked per week");
            string emp1Hours = Console.ReadLine();
            //finds weekly pay and annual
            int emp1Total = Convert.ToInt32(emp1Pay) * Convert.ToInt32(emp1Hours);
            int emp1Annual = emp1Total * 52;
            //Gets employee two's info
            Console.WriteLine("Enter second employee's hourly pay rate:");
            string emp2Pay = Console.ReadLine();
            Console.WriteLine("Enter their hours worked per week");
            string emp2Hours = Console.ReadLine();
            //finds weekly pay and annual
            int emp2Total = Convert.ToInt32(emp2Pay) * Convert.ToInt32(emp2Hours);
            int emp2Annual = emp2Total * 52;
            Console.WriteLine("Annual salary of person 1:\n" + emp1Annual);
            Console.WriteLine("Annual salary of person 2:\n" + emp2Annual);
            //compares salaries to see who's is bigger
            bool compareSal = emp1Annual > emp2Annual;
            Console.WriteLine("Is employee 1's salary bigger?:\n" + compareSal); 
            Console.Read();



        }
    }
}
