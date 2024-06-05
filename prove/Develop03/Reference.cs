public class Reference
{
    public string _book = "John";
    public int _chapter = 3;
    public int _verse = 16;

    public void RefDisplay()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }
}