using System;

class Program
{
    // static int Average(List<int> numbers)
    // {
    //     int sum = 0;
    //     int count = 0;

    //     foreach(int num in numbers)
    //     {
    //         count += 1;
    //         sum += num;
    //     } 
    //     int average = sum/count;
    //     return average;
    // }
    
    static void Main(string[] args)
    {
        List<int>numbers = new();
        int number; // variable for the input number of the user
        int sum = 0; //variable for the sum  
        int largeNumber  = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        do
        {
        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine());
        if (number > largeNumber)
        {
            largeNumber = number;
        }
        if (number != 0)
        {
            numbers.Add(number);
        }
        } while (number != 0);

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i]; //This will acumulate the sum
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = sum / numbers.Count;

        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largeNumber}");
    }
}