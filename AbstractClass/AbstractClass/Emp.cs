using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Emp : AbsCls1
    {
    public override void SayName()//this is the method when it is defined
        {
            Console.WriteLine("Full name is " + name + " " + Lname);
        }
    }
}
