using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    public class Animal
    {
        public string AnimalName { get; set; }
        public bool Hostile { get; set; }
        public Animal(string name) : this(name, false)//this chained constructor that enable the second parameter to be optional
        {
        }
        public Animal(string name, bool isHostile)//this is the root consturctor 
        {
            AnimalName = name;
            Hostile= isHostile; 
        }
    }
}
