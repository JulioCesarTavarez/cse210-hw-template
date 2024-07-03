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
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }
    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }
    public double GetFloutValue()
    {
        return (double)_numerator / _denominator;
    }

    public void GetBottom()
    {
        Console.Write("Please Enter denominator");
        _denominator = int.Parse(Console.ReadLine());
    }
}