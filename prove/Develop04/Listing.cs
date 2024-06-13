using System.Runtime.InteropServices;

class Listing : Activity
{
    public Listing(string title,string description) : base(title, description)
    {
        Timer time = new();
        int seconds = time.GetSeconds();
        float time_remaining = seconds - 5;

        time.GetReady();
        List<string> questions = new();
        questions.Add("Who are people that you appreciate? ");
        questions.Add("What are personal strengths of yours? ");
        questions.Add("Who are people that you have helped this week?");
        questions.Add("When have you felt the Holy Ghost this month?");
        questions.Add("Who are some of your personal heros?");


        int index = new Random().Next(questions.Count);
        string prompt = (questions[index]);
        int sec = 5;
        while (sec > 0)
        {
            Console.Clear();
            Console.WriteLine(prompt);
            Console.Write($"You have {sec} seconds to think about it.");
            Thread.Sleep(1000);
            sec -= 1;
            Console.CursorLeft = 0;
        }
        Console.WriteLine("");
        List<string> answers = new();
        DateTime start = DateTime.Now;
        DateTime end = DateTime.Now.AddSeconds(time_remaining);
        while (start < end)
        {
            Console.Write("Enter an answer: ");
            string answer = Console.ReadLine();
            answers.Add(answer);
            start = DateTime.Now;
        }
        Console.Clear();
        int items = answers.Count;
        Console.WriteLine("You have completed the activity. Here are your results: ");
        Console.WriteLine($"Items Entered: {items}");
        foreach (string item in answers)
        {
            Console.WriteLine(item);
        }

        Ending(title, seconds);



    }
}