using System.Data;
using System.Reflection.Metadata.Ecma335;

public class Goal
{
    protected int _points;
    private int _totalPoints;
    protected string _goalName;
    List<string>_completed = new();
    List<int> _completedPoints = new();

    public void Update_date_line()
    {}
    public string GetGoalName()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        return _goalName;
    }

    public int GetPoints()
    {
        Console.Write("How many points is this goal worth? ");
        _points = int.Parse(Console.ReadLine());
        return _points;
    }

    public string Getdescription()
    {
        Console.WriteLine("Enter a description of the goal: ");
        string description = Console.ReadLine();
        return description;
    }    

    public int GetTotalPoints(List<int> _completedPoints)
    {
        foreach (int goal in _completedPoints)
        {
            _totalPoints += goal;
        }
        return _totalPoints;
    }

}
