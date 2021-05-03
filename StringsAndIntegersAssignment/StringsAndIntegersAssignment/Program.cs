using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool reset = true;
            while (reset)
            {
                try
                {
                    List<int> numLst = new List<int>();
                    numLst.Add(2);
                    numLst.Add(3);
                    numLst.Add(54);
                    Console.WriteLine("Please enter a number to divide by");
                    int uNum = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < numLst.Count(); i++)//iterates through the int list and divide by given number
                    {
                        Console.WriteLine(numLst[i] / uNum);
                        
                    }
                    reset = false;
                    Console.ReadLine();
                
                }
                //catch blocks made, no need for finally because it is handled by while loop
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Cannot divide by 0.");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Must enter a whole number.");
                }
            }
            }
            
        }
    }

