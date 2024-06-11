class Timer
{
    public void Start(int seconds)
    {
        Console.WriteLine($"Ready...");
        Thread.Sleep(1000);
        Console.WriteLine($"Set...");
        Thread.Sleep(1000);
        Console.WriteLine($"Go...");
        Thread.Sleep(seconds * 1000);
    }
}