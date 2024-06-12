public class ReflectionActivity : Activity
{
    public ReflectionActivity(string title, string description) : base(title, description)
    {
        Timer time = new();
        int seconds = time.GetSeconds();
        List<string> prompts = new();
        List<string> questions = new();

        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did somethin truly selfish.");

        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");

        time.GetReady();
        float amount = (seconds-5)/5;
        int x = 0;
        int y = 0;


        int prompt_index = new Random().Next(prompts.Count);
        Console.WriteLine(prompts[prompt_index]);
        while (y < 5)
        {
            Animation();

            y++;
        }

        while (x < amount)
        {
            int index = new Random().Next(questions.Count);
            Console.WriteLine($"\n{questions[index]}");
            y=0;
            while (y < 5)
            {
                Animation();

                y++;
            }
            x+=1;
        }



        Ending(title, seconds);

    }
}