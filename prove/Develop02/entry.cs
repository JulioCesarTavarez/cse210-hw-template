using System;
using Microsoft.VisualBasic;

public class Entry
{
    public DateTime Date { get; private set; }
    public string Prompt { get; private set; }
    public string Content { get; private set; }

    public void PromptUser()
    {
        Date = DateTime.Now;
        Prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(Prompt);
        Console.Write("Your response: ");
        Content = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"\nDate: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Content: {Content}\n");
    }

    public override string ToString()
    {
        return $"{Date}\t{Prompt}\t{Content}";
    }

    public static Entry FromString(string line)
    {
        string[] parts = line.Split('\t');
        if (parts.Length == 3)
        {
            return new Entry
            {
                Date = DateTime.Parse(parts[0]),
                Prompt = parts[1],
                Content = parts[2]
            };
        }
        throw new FormatException("Invalid entry format.");
    }
}