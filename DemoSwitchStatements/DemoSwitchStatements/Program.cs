using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DemoSwitchStatements
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This is an example of a while loop");
            int i = 0;
            do // do while allows the program to enter the while loop atleast once even if the condition is met 
            {
                Console.WriteLine(i);
                i++;
                Thread.Sleep(100);
            }
            while (i < 5);
            Console.Read();
        }
    }
}
