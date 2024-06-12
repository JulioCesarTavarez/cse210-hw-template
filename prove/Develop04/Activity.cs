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

            Thread.Sleep(333);
        }
    }

    public void Ending(string activityTitle, int time)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");


        Console.WriteLine();
        Console.WriteLine("Well done!");
        int amount = 0;
        while (amount < 5)
        {
            foreach (string iteem in animation)
            {
                Console.Write($"\b\b\b\b   {iteem}\b\b\b\b");

                Thread.Sleep(333);
            }

            amount++;
        }


        Console.WriteLine($"\nYou have completed the {activityTitle}.");

        Console.WriteLine($"You have completed it for {time} seconds.");
    }
}