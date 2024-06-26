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
}