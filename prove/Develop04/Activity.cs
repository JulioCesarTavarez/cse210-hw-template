public class Activity
{
    protected string _title;
    protected string _description;
    protected int _time;

    public Activity(string title, string description)
    {
        _title = title;
        _description = description;
      


        Console.WriteLine($"Welcome to the {_title} activity.");

        Console.WriteLine($"{_description}.");






        

    }
}