using System;
using Microsoft.VisualBasic;
using System.IO;

public class Mainmenu
{
    static void Main()
    {
        bool loop = true;
        while (loop == true){
        // display options
        Journal journal = new();
        Console.WriteLine("\nWelcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quite");
        Console.Write("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());

    if (choice == 1) // if they enter one they write an entry.
        {
            journal.WriteEntry();
        }
    else if (choice == 2) // if they enter 2 they will get displayed an entry
        {
            journal.DisplayEntries();
        }
    else if (choice == 3)// if they enter 3 they will load past entries
        {
            journal.LoadEntries();
        }
    else if (choice == 4) // 4 will save entires
        {
            journal.SaveEntries();
        }
    else if (choice == 5) // this will exit the program and say goodbye
        {
            Console.WriteLine("Goodbye!");
            return;
        }
    else // if a number other then 1-5 is picked it will ask the user to try again
        {
            Console.WriteLine("Invalid choice, please try again.");
        }
    }    
    }
    



    static string LoadFile(string filePath)
    {
        string fileContents = File.ReadAllText(filePath);
        return fileContents;
    }
    
    static void Load()
    {
        Console.WriteLine("Please enter file you want to load");
        string filePath = Console.ReadLine();
        string fileContents = LoadFile(filePath);

        if (fileContents != null)
            {
                Console.WriteLine("content: ");
                Console.WriteLine(fileContents);
            }
        else
            {
                Console.WriteLine($"Failed to loadthe file: {filePath}");
            }

    }
}