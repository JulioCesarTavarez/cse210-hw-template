class Eternal : Goal
{
    public Eternal(string goalName, string description, int points) : base(goalName, description, points)
    {
  
    }

    public override void RecordEvent()
    {
        AddPoints(_points);
        Console.WriteLine("Event recorded for Eternal goal.");
    }
}