using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcomemessage();
        string userName = UserNamePrompt();
        int userNumber = FavNumberPrompt();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);


    }

    static void DisplayWelcomemessage()
    {
        Console.WriteLine("Welcome to my program!");
    }


    static string UserNamePrompt()
    {
        Console.Write("Please enter your full name.");
        string name = Console.ReadLine();
        
        return name;
    }

    static int FavNumberPrompt()
    {
        Console.Write("What is your favorite number?");
        int number = int.Parse(Console.ReadLine());
        return number;
    }


    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }


    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, your number squared is {square}");
    }








}