using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name:");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int x)
    {
        int squared = x * x;
        return squared; 
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favoritNumber = PromptUserNumber();
        int favoriteNumberSquared = SquareNumber(favoritNumber);
        Console.WriteLine($"{name}, the square of your number is {favoriteNumberSquared}");
    }
}