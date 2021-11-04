using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();//instance of the class 
            emp.name = "Sample";//intialized properties of class are -
            emp.Lname = "Name";//here 
            emp.SayName();//Called the abstract method through the emp class and uses the context of the intialized properties
            emp.Quit(emp.name);//calls Quit method from the emp class
            Console.ReadLine();//keeps window open 

        }
    }
}
