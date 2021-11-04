using System;


class Program
{
    static void Main()
    {
        //Prompt for name
        Console.WriteLine("The Tech Academy\n\nName:");
        string name = Console.ReadLine();
        //Prompt for course name
        Console.WriteLine("What course are you on " + name + "?");
        string course = Console.ReadLine();
        //Prompt  for step number
        Console.WriteLine("What step are you on?");
        string step = Console.ReadLine();
        //Prompt for Help
        Console.WriteLine("Do you need any help understanding a concept answer y/n");
        string needhelp = Console.ReadLine();
        //Prompt for success story
        Console.WriteLine("Please share any success stories in specific detail?");
        string successStory = Console.ReadLine();
        //Prompt for feedback
        Console.WriteLine("Please give any other feedback here");
        string feedback = Console.ReadLine();
        //Prompt study hours
        Console.WriteLine("How many hours of study did you complete today Input (must be a number ex. 8)");
        string study = Console.ReadLine();
        //Cast string to int
        int studyHours = Convert.ToInt32(study);
        //enter conditional 
        if (studyHours >= 8)
        {
            //if student gets 8 or more hours of study 
            Console.WriteLine("Wow, great job getting " + studyHours + " hours in, and thanks for your report " + name + "!");
        }
        else 
        {
            //else we find remaining hours by taking expected hours then finding the difference with int input
            int remain = 8 - studyHours;       
            Console.WriteLine("Thanks for your report, make sure to get make up your remaining " + remain + " hour(s) of study" + name + " !");
        }
        //This is to keep the window from closing
        Console.Read();
    }
}

