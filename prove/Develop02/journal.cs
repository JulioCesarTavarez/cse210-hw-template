using System;
using Microsoft.VisualBasic;


public class Journal
{
    List<Entry> entries = new List<Entry>();

    public void WriteEntry()
    {
        Entry newEntry = new();
        newEntry.PromptUser();
        entries.Add(newEntry);
        Console.WriteLine("Entry added successfully.");
    }
        public void DisplayEntries()
    {
        foreach (Entry entry in entries) // this will display al the entries in the list
        {
            entry.Display();
        }
    }
    public void LoadEntries() // this doesnt really work
    {
        Console.Write("Please enter the file you want to load: ");
        string filePath = Console.ReadLine();
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            entries.Clear();
            foreach (string line in lines)
            {
                Entry entry = Entry.FromString(line);
                entries.Add(entry);
            }
            Console.WriteLine("Entries loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to load the file: {ex.Message}");
        }
    }

    public void SaveEntries() //this doesnt really work either but I tried.
    {
        Console.Write("Please enter the file name to save: ");
        string filePath = Console.ReadLine();
        try
        {
            List<string> lines = new List<string>();
            foreach (Entry entry in entries)
            {
                lines.Add(entry.ToString());
            }
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Entries saved successfully.");
        }
        catch (Exception ex)
            {
            Console.WriteLine($"Failed to save the file: {ex.Message}");
        }
    }
}
