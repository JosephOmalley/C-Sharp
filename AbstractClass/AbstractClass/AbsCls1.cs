using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class AbsCls1//here we have an abstract class, this class cannot be directly instatiated. It must be inherited from another class that details the implementation
    {
        public string name { get; set; }//class properties
        public string Lname { get; set; }

        public abstract void SayName();//this is an abstract method. It does not contain a body and the body is given in emp class  
    }
}
