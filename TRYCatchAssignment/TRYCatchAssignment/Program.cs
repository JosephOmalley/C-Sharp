using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRYCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you?");
                int uAge = Convert.ToInt32(Console.ReadLine());
                if (uAge <= 0)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine("You were born in " + DateTime.Now.AddYears(-uAge + -1).Year);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invaild input. make sure your entry was not zero, or a negitive number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input must be a digit");

            }
            Console.ReadLine();
            
        }
    }
}
