using System;
using Microsoft.VisualBasic;


public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void WriteEntry()
    {
        Entry newEntry = new();
        newEntry.PromptUser();
        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully.");
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries) // this will display al the entries in the list
        {
            entry.Display();
        }
    }
    public void LoadEntries() // this might work but you have to have an actual file to type in to load.
    {
        Console.Write("Please enter the file you want to load: ");
        string filePath = Console.ReadLine();
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            _entries.Clear();
            foreach (string line in lines)
            {
                Entry entry = Entry.FromString(line);
                _entries.Add(entry);
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
            foreach (Entry entry in _entries)
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
