using System.Data;
using System.Reflection.Metadata.Ecma335;

public class Goal
{
    static protected int _points;
    protected static int _totalPoints = 0;
    protected string _goalName;
    protected string _description;

    public Goal(string goalName, string description, int points)
    {
        _points = points;
        _goalName = goalName;
        _description = description;
    
    }

    public virtual bool IsComplete()
    {
        
        
        return false;
    }

    public void Update_date_line()
    {}
    public static string InputGoalName()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        return goalName;
    }

    public static int InputPoints()
    {
        Console.Write("How many points is this goal worth? ");
        int points = int.Parse(Console.ReadLine());
        return points;
    }

    public static string InputDescription()
    {
        Console.WriteLine("Enter a description of the goal: ");
        string description = Console.ReadLine();
        return description;
    }    
    public static void AddPoints(int points)
    {
        _totalPoints += points;
    }

    public static int GetTotalPoints()
    {
        
        return _totalPoints;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($" {_goalName}: {_description} ({_points} points)");
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine("Recording event for a generic goal.");
        // Add more generic behavior here if needed
    }
}
