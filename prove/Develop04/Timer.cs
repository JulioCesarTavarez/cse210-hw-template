public class Timer
{
    public int GetSeconds()
    {
        Console.WriteLine($"How long would you like to do this activity in seconds? ");
        int sec = int.Parse(Console.ReadLine());
        return sec;
    }
}