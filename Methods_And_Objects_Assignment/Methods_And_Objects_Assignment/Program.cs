using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee person = new Employee(); //instatiates the object employee from the Employee class (Empyloyee class directly inherites person) object called person
            person.Name = "Bill"; //intialize Name will Bill
            person.Lname = "Smith";//intialize Lname will Smith
            person.SayName();//when this superclass method SayName is called in the context of the the object it pass the objects values  
            Console.ReadLine();

        }
    }
}
