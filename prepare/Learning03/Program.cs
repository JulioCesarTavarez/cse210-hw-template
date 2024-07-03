using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new();

        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetFloutValue());

        Fraction f1 = new(5);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetFloutValue());

        Fraction f2 = new(3, 4);

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetFloutValue());

        Fraction f3 = new(1, 3);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetFloutValue());

    }
}