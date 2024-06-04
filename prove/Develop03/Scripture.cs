public class Scripture
{

    public List<string> Words = new List<string>()
    {
        "For", "God", "so", "loved", "the", "world", "that", "he", "gave", "his", "one", "and", "only", "Son",
    };

    public string reference = "John 3:16";
    public void Display()
    {
        Console.WriteLine($"{reference}");
        
        foreach(string word in Words)
        {
            Console.Write($"{word} ");
        }
    }


}