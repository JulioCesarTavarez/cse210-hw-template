using System;
using Microsoft.VisualBasic;

public class Entry
{
    static void Get_date()
    {
        DateTime currentDate = DateTime.Now;
        Console.WriteLine($"Written at {currentDate}");
    }
    static void Input()
    {
        Console.ReadLine();
    }
}