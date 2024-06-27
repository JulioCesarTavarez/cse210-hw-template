class Checklist: Goal
{
    bool _finished = false;
    int _compare_times_done;
    int _total_times_done;
    int _bonuspoint;

    public Checklist(string goalName, string description, int points, int compare_times_done, int bonuspoint) : base(goalName, description, points)
    {

        _compare_times_done = compare_times_done;
        _total_times_done = 0;
        _bonuspoint = bonuspoint;


    }

    public override bool IsComplete()
    {

        if (_total_times_done >= _compare_times_done)
        {
            _finished = true;
        }
        return _finished;
    }

    public static int InputTimesToDo()
    {
        Console.Write("How many times do you want to do this goal?");
        int compare_times_done = int.Parse(Console.ReadLine());

        return compare_times_done;
    }

    public static int InputBonusPoint()
    {
        Console.Write("When you have done it for the last time how mny bonus points do you want to add?");
        int bonuspoint = int.Parse(Console.ReadLine());
        return bonuspoint;
    }
    public override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.WriteLine($"Times done: {_total_times_done}/{_compare_times_done}, Bonus points: {_bonuspoint}");
    }

    public override void RecordEvent()
    {
        if (_total_times_done < _compare_times_done)
        {
            _total_times_done++;
            Console.WriteLine("Event recorded for Checklist goal.");
            if (IsComplete())
            {
                AddPoints(_points + _bonuspoint);
                Console.WriteLine("Goal completed! Bonus points added.");
            }
            else
            {
                AddPoints(_points);
            }
        }
        else
        {
            Console.WriteLine("This Checklist goal is already complete.");
        }
    }
}