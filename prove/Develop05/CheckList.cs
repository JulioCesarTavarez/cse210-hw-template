class Checklist: Goal
{
    bool _finished = false;
    int _compare_times_done;
    int _total_times_done;

    public Checklist(string goalName, string description, int points, int compare_times_done) : base(goalName, description, points)
    {

        _compare_times_done = compare_times_done;
        _total_times_done = 0;


    }

    public override bool IsComplete()
    {

        return _finished;
    }

    public static int InputTimesToDo()
    {
        Console.Write("How many times do you want to do this goal?");
        int compare_times_done = int.Parse(Console.ReadLine());

        return compare_times_done;
    }
}