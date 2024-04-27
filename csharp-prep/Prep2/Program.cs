using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade: ");
        string grade = Console.ReadLine();
        int number_grade = int.Parse(grade);
        string letter = "Z";

        if (number_grade >=70)
        {
            letter = "C";
            if (number_grade >=90)
            {
                letter = "A";
            }
            else if (number_grade >= 80)
            {
                letter = "B";
            }
            
        }
        else if (number_grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (number_grade >= 70)
        {
            Console.WriteLine("Congratulations! You Passed the class!");
            
        }
        else
        {
            Console.WriteLine("Dont worry, try the class again you are sure to pass!");
            
        }

    }
}