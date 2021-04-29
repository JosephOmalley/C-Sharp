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

        // do while example
        Console.WriteLine("This is an example of a do while loop");
        int i = 0;
        do // do while allows the program to enter the while loop atleast once even if the condition is met 
        {
            Console.WriteLine(i);
            i++;
            Thread.Sleep(100);
        }
        while (i < 5);
        
        //while loop example
        Console.WriteLine("This is an example of a plain while loop");
        bool track = true;
        while (track)
        {
            Console.WriteLine("What's is the sum of 4 and 9?");
            int result = Convert.ToInt32(Console.ReadLine());
            
            if (result == 13)
            {
                Console.WriteLine("13 is the right answer!");
                track = false;
            }
            else
            {
                Console.WriteLine(result + " is not the right answer, please try again.");

            }
        }
        Console.WriteLine("Press any key to stop to program");
        Console.ReadLine();
        return;



        }
    }
}
