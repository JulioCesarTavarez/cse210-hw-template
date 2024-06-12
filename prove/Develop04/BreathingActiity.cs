using System.Runtime.InteropServices;

public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity(string title,string description) : base(title, description)
    {
        Timer time = new();
        int seconds = time.GetSeconds();
        int x = 0;
        float amount = seconds / 6;

        time.GetReady();

        while (x < amount)
        {
            Console.WriteLine("Breathe in...");
            Console.WriteLine("3 seconds");
            Animation();
            Console.Clear();
            Console.WriteLine("Breathe in...");
            Console.WriteLine("2 seconds");
            Animation();
            Console.Clear();
            Console.WriteLine("Breathe in...");
            Console.WriteLine("1 seconds");
            Animation();
            Console.Clear();

            
            Console.WriteLine("Breathe out...");
            Console.WriteLine("3 seconds");
            Animation();
            Console.Clear();
            Console.WriteLine("Breathe out...");
            Console.WriteLine("2 seconds");
            Animation();
            Console.Clear();
            Console.WriteLine("Breathe out...");
            Console.WriteLine("1 seconds");
            Animation();
            Console.Clear();

            x += 1;
        }


    Ending(title, seconds);

    }
}