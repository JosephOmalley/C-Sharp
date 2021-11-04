using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> empFname = new List<string>() { "Joe", "Bob", "Joe", "Rich", "Jill", "Mark", "Ronda", "Mike", "John", "Amy" };
            List<string> empLname = new List<string>() { "Thompson", "Nickelson", "Smith", "Earl", "Williams", "Jones", "Garcia", "Miller", "Davis" };
            List<int> empId = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int count = 0;
            foreach (string i in empFname)
            {
                if (i == "Joe")
                {
                    count++;
                }
            }
            Console.WriteLine("The name Joe appeared " + count + " times");

            List<string> newList = empFname.Where(x => x == "Joe").ToList();
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine(newList[i]);
            }

            List<int> IdLst = empId.Where(x => x > 5).ToList();
            Console.WriteLine("Here is all of the employee ids over 5 ");
            for (int j = 0; j < IdLst.Count; j++)
            {
                Console.WriteLine("Name: " + empFname[IdLst[j]] + " Id: " + IdLst[j]);
            }
            Console.ReadLine();

        }
    }
}
