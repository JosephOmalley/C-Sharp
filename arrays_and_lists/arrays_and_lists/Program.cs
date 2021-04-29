using System;
using System.Collections.Generic;




class Program
{
    static void Main()
    {
        List<int> intlist = new List<int>();
        intlist.Add(4);
        intlist.Add(10);
        intlist.Remove(10);

        Console.WriteLine(intlist[0]);
        Console.ReadLine();
    }
}

