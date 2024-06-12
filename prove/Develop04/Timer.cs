public class Timer
{
    public int GetSeconds()
    {
        Console.WriteLine($"\nHow long would you like to do this activity in seconds? ");
        Console.Write($"Seconds: ");
        int sec = int.Parse(Console.ReadLine());
        return sec;
    }

    public void GetReady()
    {
        List<string> readySetGO = new List<string>();
        readySetGO.Add("Get ready...");
        readySetGO.Add("Get set...");
        readySetGO.Add("Go!");

        foreach (string iteem in readySetGO)
        {

            Console.Write($" {iteem}");
            Thread.Sleep(1000);
            int position = Console.CursorLeft;
            for (int i = position; i > 0; i--)
            {
                Console.Write("\b \b");
            }
        }

        Console.Clear();
    }
}