using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_of_week_Parsing_enums
{
    class Program
    {
        public enum DaysOfTheWeek //enum DaysOfTheWeek created 
        {
            Monday,
            Tuesday,
            Wensday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            bool check = true;//while loop checker
            while (check)
            {
                Console.WriteLine("What\'s the current day of the week?");
                string uInp = Console.ReadLine();//string input 
                try
                {
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), uInp);//set object day to the user input uInp if uInp is one of the elements in the enum 
                    Console.WriteLine(day + " is a valid input");
                    Console.ReadLine();
                    check = false;
                }
                catch (ArgumentException)//catches any invaild input
                {
                    Console.WriteLine("Error: " + uInp + " is not valid input");
                    
                }
            }            
        }
    }
}

