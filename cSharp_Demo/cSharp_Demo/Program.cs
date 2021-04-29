using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Demo
{
    class Program
    {
        static void Main()
        {
            int roomTemp = 70;
            Console.WriteLine("what is your favorite number");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "I have the same favorite number!" : "Cool mine is 12!";
            Console.WriteLine(result);
            Console.Read();

            //Console.WriteLine("Hi, " + name + "what temp is it where you are");
            //int curTemp = Convert.ToInt32(Console.ReadLine());

            //if (curTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if  (curTemp > roomTemp)
            //{
            //    Console.WriteLine("Wow its hotter than room temp");

            //}
            //else
            //{
            //    Console.WriteLine("what????");   
            //}
            //Console.Read();



            //int curTemp = 80;
            //int roomTemp = 70;
            //string CompareRe = curTemp == roomTemp ? "It is room temp" : "it is not room temp";
            //Console.WriteLine(CompareRe);
            //Console.ReadLine();
        }
    }
}
