using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter a grade percentage: ");
        string percentFromUser = Console.ReadLine();

        int x = int.Parse(percentFromUser);
        
        string grade = "";

        if (x >= 90)
        {
            grade = "A";
        }

        else if (x >= 80)
        {
            grade = "B";
        }
        else if (x >= 70)
        {
            grade = "C";
        }
        else if (x >= 60)
        {
            grade = "D";
        }

        else 
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");


        if (x>= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("Sorry you did not pass. Better Luck next time!");
        }


    }
}