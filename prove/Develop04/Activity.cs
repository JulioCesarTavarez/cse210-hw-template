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

    public void Animation()
    {
        List<string> animation = new List<string>();

        animation.Add("Ooo");
        animation.Add("oOo");
        animation.Add("ooO");

        foreach (string iteem in animation)
        {
            Console.Write($" {iteem}\b\b\b\b");

            Thread.Sleep(3000);
        }
    }
}