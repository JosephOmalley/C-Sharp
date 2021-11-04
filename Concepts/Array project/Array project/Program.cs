using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_project
{
    class Program
    {
        static void Main()
        {
            //example of string array
            string[] Choice = { "Banana", "Grapefruit", "Pear" };
            bool check = true;
            while (check)
            {
                Console.WriteLine("Pick a number 0-2, for a random fruit");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i >= 0 && i <= 2)
                {
                    Console.WriteLine(Choice[i]);
                    check = false;
                }
                else
                {
                    Console.WriteLine("Only options are 0 1 2 ");
                }
            }
            //example of int array
            int[] Choice1 = { 12, 35, 65, 67 };
            bool check1 = true;
            while (check1)
            {
                {
                    Console.WriteLine("Pick a number 0-3, for a random number");
                    int i = Convert.ToInt32(Console.ReadLine());
                    if (i >= 0 && i <= 3)
                    {
                        Console.WriteLine(Choice1[i]);
                        check1 = false;
                    }
                    else
                    {
                        Console.WriteLine("Only options are 0 1 2 3 ");
                    }
                }
            }
            //example of list of strings
            List<string> choice2 = new List<string> { "rock", "gold", "rock" };
            bool check2 = true; 
            while (check2)
            {
                Console.WriteLine("Pick a number 0-2, for a 1-3 chance of getting gold");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i >= 0 && i <= 2)
                {
                    Console.WriteLine("you got " + choice2[i]);
                    check2 = false;
                }
                else
                {
                    Console.WriteLine("Only options are 0 1 2 3 ");
                }
            }



            Console.WriteLine("Press any button to exit program");
            Console.ReadLine();
            return;
        }
    }
}
