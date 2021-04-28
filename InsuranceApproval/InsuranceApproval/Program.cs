using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            //put data in vars
            Console.WriteLine("What is your age ?");
            string age = Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? y/n");
            string hadDUI = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            //See if all statements are true
            if (Convert.ToInt32(age) > 15 && hadDUI == "n" && Convert.ToInt32(tickets) < 3)
                Console.WriteLine("Congratulations, You qualify!");
            else
                Console.WriteLine("Sorry, you do not qualify!");
            Console.Read();
        }
    }
}
