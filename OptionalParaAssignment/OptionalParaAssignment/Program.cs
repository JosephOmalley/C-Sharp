using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter a number");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(var1 + " will be added by 1 50 times. To change the increment value enter another number else just hit enter");
            try
            {
                int var2 = Convert.ToInt32(Console.ReadLine());//If whole number detected runs method with optional parameter taken.
               
                Class1.MethodIncrement(var1, addBy: var2);
                
                Console.Read();

            }
            catch (FormatException)//if the the second prompt is left blank or a invalid input it will default to 1
            {
                Class1.MethodIncrement(var1);
                Console.ReadLine();
            }
            

         
            
            
        }
        
    }
}
