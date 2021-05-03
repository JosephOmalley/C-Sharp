using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This app has the user input a string
//this string is then add on to the end of various words
//the user then has the option to pick one of the set of their word
//and one of the string then they are to keep adding more string on 
//to it and then they will be left with a sentence 
namespace BlindWriteConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] sent0 = { "There once was a black smith named " , "There once was a tailer named " , "There once was a ship builder named " };
            Console.WriteLine("Please enter your name:");
            string username = Console.ReadLine();
            //converts immutable array to a mutable list
            List<string> list = new List<string>(sent0.ToList());
            //appends each string in the list with user clothes
            for (int i = 0; i < list.Count(); i++)
            {
                 list[i] += username + ". ";
            }
            //converts list back to array 
            sent0 = list.ToArray();
            //logs each new string to the console
            foreach (string i in sent0)
            {
                Console.WriteLine(i);
            }
            bool check = true;
            //this var allows for the choice var to have greater scope
            int choice = 0;
            //has user input int of index and checks range
            while (check)
            {
            Console.WriteLine("Please choose a string 0 - 2 ");
            choice += Convert.ToInt32(Console.ReadLine());
                if (choice >= 0 && choice <= 2)
                {
                    Console.WriteLine(sent0[choice]);
                    
                    check = false;
                }
            }
            
            Console.WriteLine("You've choosen your theme!");
            List<string> desc0 = new List<string>();
            desc0.Add("They wore purple clothes");
            desc0.Add("They wore red clothes");
            desc0.Add("They wore yellow clothes");
            bool test = true;
            string input = null;
            //this checks if the user inputed the correct string
            while (test)
            {
                Console.WriteLine("Enter a color to get a description of your character. options: red | purple | yellow");
                input = Console.ReadLine();
                if (input == "red" || input == "yellow" || input == "purple")
                {
                    test = false;
                }
                else
                {
                    Console.WriteLine("Please enter red | purple | yellow");
                    
                }
            }
            //this prints results 
            foreach (string str in desc0)
            {
                if (str.Contains(input))
                {
                    Console.WriteLine(sent0[choice] + str + ". ");
                }
             
            }
            
            List<string> dupStr = new List<string>();
            dupStr.Add(", and lived in a small town");
            dupStr.Add(", and lived in a big town");
            dupStr.Add(", and lived in alone in the woods");
            dupStr.Add(", and lived in alone in the woods");
            bool check2 = true;
            string uInput = null;
            while (check2)
            //this prints all the indices of the elements in the list that contain the users input
            {
                Console.WriteLine("enter keyword to find where your character lives. Try woods or town");
                uInput = Console.ReadLine();
                if (uInput == "woods" || uInput == "town")
                {
                    check2 = false; 
                }
                else
                {
                    Console.WriteLine("Please enter vaild text input not on list");
                }
            }
            for (int i = 0; i < dupStr.Count(); i++)
            {
                if (dupStr[i].Contains(uInput))
                {
                    Console.WriteLine(i);
                }
            }

            //this checks if there are duplicate strings in the list
            List<string> checkDupString = new List<string>();
            checkDupString.Add("dupStr");
            checkDupString.Add("dupStr");
            checkDupString.Add("nonDup");
            foreach (string nondup in checkDupString)
            {
                if (nondup == checkDupString[1] || nondup == checkDupString[2])
                {
                    Console.WriteLine("Duplicates have been found in the list");
                }
            }
            Console.ReadLine();













        }
    }
}
