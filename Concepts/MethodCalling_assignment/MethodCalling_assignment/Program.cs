using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCalling_assignment
{
    class Program
    {
        static void Main(string[] args) //entrance point of the program
        {
            
            bool check = true;
            while (check)//Loops until proper input 
            {
                try // ensure the user enters valid data type
                {
                    Console.WriteLine("enter a number to add it to 1");
                    int num = Convert.ToInt32(Console.ReadLine());
                    MethodClass.AddMethod(num);
                    check = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input must be a whole number");
                }
            }



            bool check1 = true;
            while (check1)//Loops until proper input 
            {
                try // ensure the user enters valid data type
                {
                    Console.WriteLine("enter a number to double it ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    MethodClass.doubleNum(num1);
                    check1 = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input must be a whole number");
                };
            }

            
            bool check2 = true;
            while (check2)//Loops until proper input 
            {

                try // ensure the user enters valid data type
                {
                    Console.WriteLine("Enter the total of the bill to find tip amount");
                    int bill = Convert.ToInt32(Console.ReadLine());
                    MethodClass.FindTip(bill);
                    Console.ReadLine();
                    check2 = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input must be a whole number");
                }
            }
            Console.WriteLine("Press any key to exit the program");//Where the program exits
            Console.ReadLine();

        }

    }
}
