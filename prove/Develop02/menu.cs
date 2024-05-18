using System;
using Microsoft.VisualBasic;
using System.IO;

public class Mainmenu
{
    static void Main()
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("Save");
        Console.WriteLine("Quite");
        Console.Write("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());

if (choice == 1)
                {
                    journal.WriteEntry();
                }
                else if (choice == 2)
                {
                    journal.DisplayEntries();
                }
                else if (choice == 3)
                {
                    journal.LoadEntries();
                }
                else if (choice == 4)
                {
                    journal.SaveEntries();
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
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