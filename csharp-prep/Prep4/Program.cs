using System;

class Program
{
    static int Average(List<int> numbers)
    {
        int sum = 0;
        int count = 0;
        int average = 0;
        foreach(int num in numbers)
        {
            count += 1;
            sum += num;
        } 
        average = sum/count;
        return average;
    }
    
    static void Main(string[] args)
    {
        List<int>numbers = new();
        int number; // variable for the input number of the user
        int sum = 0; //variable for the sum  

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        do
        {
        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine());
        numbers.Add(number);

        } while (number != 0);

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i]; //This will acumulate the sum
        }
        Console.WriteLine($"The sum is: {sum}");
        int average = Average(numbers);

        Console.WriteLine($"The average is: {average}");
    }
}