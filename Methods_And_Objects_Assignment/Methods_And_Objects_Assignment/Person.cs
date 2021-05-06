using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects_Assignment
{
    public class Person
    {
        public string Name { get; set; }
        public string Lname { get; set; }
        
        
        
        public void SayName()
        {
            Console.WriteLine("Name: " + Name + " " + Lname);
        }

    }
}
