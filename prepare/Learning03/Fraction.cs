using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int wholeNumber)
    {}
    public Fraction(int top, int bottom)
    {}

    public void GetTop()
    {
        Console.Write("Please Ennter numerator");
        _numerator = int.Parse(Console.ReadLine());
    }
    public SetTop(int top)
    {
        _numerator = top;
    }

    public void GetBottom()
    {
        Console.Write("Please Enter denominator");
        _denominator = int.Parse(Console.ReadLine());
    }
    public SetBottom(int bottom)
    {
        _denominator = bottom;
    }

    public GetFractionString()
    {
        // return void $"{_numerator}/{_denominator}";
    }
}