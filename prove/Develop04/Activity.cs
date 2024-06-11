public class Activity
{
    protected string _title;
    protected string _description;
    protected int _time;

    public Activity(string title)
    {
        _title = title;
      


        Console.WriteLine($"Welcome to the {_title} activity.");


        _time = int.Parse(Console.ReadLine());


    }
}