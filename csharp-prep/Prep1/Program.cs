using System;

class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine();
        /// Ask for first name.
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        /// Ask for last name.
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine();
        /// Give your name, James Bond style.
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");

        Console.WriteLine();


    

    }
}