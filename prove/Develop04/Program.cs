using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App. ");
        Console.WriteLine("Please select a number of the following choices: ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");

        int choice = int.Parse(Console.ReadLine());
        
        if (choice == 1)
        {
            BreathingActivity breathingActivity = new("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

            // breathingActivity.Activity();
        }
        else if (choice == 2)
        {
            ReflectionActivity reflectionActivity = new("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and use it in other aspects of your life.");
        }
        else if (choice == 3)
        {
            Listing listing = new("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        }
        else
        {
            Console.WriteLine("Invalid choice. please try again.");
        }
    }
}