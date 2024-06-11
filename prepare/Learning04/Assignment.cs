public class Assignment
{
    private string _studentName;
    private string _topic;
    
    public string GetSummary()
    {
        Console.WriteLine($"Please enter student's name: ");
        _studentName = Console.ReadLine();

        Console.WriteLine($"Please enter topic: ");
        _topic = Console.ReadLine();
    }
}

