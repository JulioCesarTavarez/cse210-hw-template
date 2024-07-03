using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new("Tavares", "Multiplication");

        Console.WriteLine(a.GetSummary());

        Math a1 = new("Julio Tavarez", "Fractions", "7.3","8-19");

        Console.WriteLine(a1.GetSummary());
        Console.WriteLine(a1.GetHomework());

        Writing a2 = new Writing("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetWritingInfo());
    }
}