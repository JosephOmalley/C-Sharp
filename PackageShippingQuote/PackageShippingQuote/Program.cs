using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PackageShippingQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How much does your package weigh?");
            int PacWeight = Convert.ToInt32(Console.ReadLine());
            if (PacWeight > 50)
            {
                Console.WriteLine("Sorry, this package is too heavy to be shipped!");
                
                Console.ReadLine();
                return;
                
            }
            else
            {
                Console.WriteLine("Thanks!");
          
            }
        
            Console.WriteLine("What is the package's width?");
            int PacWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Okay, what is the package's height?");
            int PacHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Okay, what is the package's length");
            int PacLength = Convert.ToInt32(Console.ReadLine());
            if (PacWidth + PacHeight > 50)
            {
                Console.WriteLine("Sorry, this package big");

                Console.ReadLine();
                return;

            }
            else
            {
                Console.WriteLine("Thanks!");

            }

            int total = PacHeight * PacWidth * PacLength / 100;
            Console.WriteLine("Your total to ship this package will be $" + total);
            Console.Read();

        }
    }
}
