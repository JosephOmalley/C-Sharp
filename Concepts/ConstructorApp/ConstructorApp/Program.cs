using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            var userName = Console.ReadLine();//since it's safe to assume that this var is going to be a string we can use var to implictly type the varible name, because the Console.ReadLine() method returns strings. 
            Console.WriteLine(userName + " <-- This can be changed");
            const string uName = "Name";
            Console.WriteLine(uName + " <-- this cannot be changed since it\'s a constant");
            Console.WriteLine("Please enter a name of an animal");
            string aniName = Console.ReadLine();
            Animal dog = new Animal(aniName);// since we have a chain constructor we can leave out the second parameter and it will assume it's false
            
            Console.WriteLine("is " + dog.AnimalName + " Hostile?");
            Console.WriteLine(dog.Hostile);
            Console.ReadLine();
        }
    }
}
