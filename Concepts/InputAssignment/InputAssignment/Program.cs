using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int userInt = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\Josep\Desktop\log.txt", true))
            {
                file.WriteLine(userInt);
            }
            Console.WriteLine("This is the data in log.txt file\n");
            using (StreamReader rFile = new StreamReader(@"C:\Users\Josep\Desktop\log.txt", true))
            {
                Console.WriteLine(rFile.ReadToEnd());
            }
            Console.ReadLine();
        }
    }
}
