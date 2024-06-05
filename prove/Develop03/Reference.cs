public class Reference
{
    private string _book = "John";
    private int _chapter = 3;
    private int _verse = 16;

    public void RefDisplay()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }
}