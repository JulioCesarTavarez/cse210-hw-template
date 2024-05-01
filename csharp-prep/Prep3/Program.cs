using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new();
        int MagicNumber = random.Next(1,101);
        int NumberGuess;
        do
        {    
            Console.Write("Guess a number between 1 and 100");
            Console.Write("What is your guess ");
            string InputGuess = Console.ReadLine();
            NumberGuess = int.Parse(InputGuess);

            if (NumberGuess < MagicNumber)
            {
                Console.WriteLine("Heiger");
            }
            else if (NumberGuess > MagicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (MagicNumber != NumberGuess);
    }
}