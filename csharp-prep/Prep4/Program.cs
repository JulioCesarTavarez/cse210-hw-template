using System;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers;
        numbers = new[];
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        do
        {
        Console.Write("Enter number");
        number = Console.ReadLine();
        numbers.Add(number);
        } while (number != 0);
    }
}