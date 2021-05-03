using System;
using System.Collections.Generic;


namespace iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 95, 75, 34, 46, 75 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score " + testScores[i]);
            //    }

            //}

            //string[] names = { "jesse", "erik", "daniel", "adam" };
            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "jesse")
            //    {
            //        Console.WriteLine(names[j]);
            //    }

            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(45);
            //testScores.Add(16);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("passing score" + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "jesse", "erik", "adam", "Daniel" };
            //foreach (string name in names)
            //{
            //    if (name == "jesse") ;
            //    {
            //        Console.WriteLine("Name is " + name);
            //        Console.ReadLine();
            //    }
            //}

            List<int> testscores = new List<int> { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();
            foreach (int score in testscores)
            {
                if (score > 85)
                {
                    passingScores.Add(passingScores.Count);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}




