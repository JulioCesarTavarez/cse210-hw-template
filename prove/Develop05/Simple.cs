class Simple : Goal
{
    bool _finished = false;
    public Simple(string goalName, string description, int points) : base(goalName, description, points)
    {
        
    }

    public override bool IsComplete()
    {
        return _finished;
    }
    public override void RecordEvent()
    {
        if (!_finished)
        {
            _finished = true;
            AddPoints(_points);
            Console.WriteLine("Event recorded for Simple goal.");
        }
        else
        {
            Console.WriteLine("This Simple goal is already complete.");
        }
    }
}