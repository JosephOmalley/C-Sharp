using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Emp : AbsCls1, IQuittable
    {
    public override void SayName()//this is the method when it is defined
        {
            Console.WriteLine("Full name is " + name + " " + Lname);
            
        }
        public void Quit(string name)//implement interface method IQuittable
        {
            Console.WriteLine(name + " says \"I QUIT!\"");
        }
    }
}
