public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity(string title,string description) : base(title, description)
    {
        Timer time = new();
        int seconds = time.GetSeconds();
        int x = 0;
        float amount = seconds / 6;

        while (x < amount)
        {
            Console.WriteLine("Breathe in...");
            
        }
    }
}