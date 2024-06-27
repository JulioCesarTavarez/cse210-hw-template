using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static private List<Goal> _goals= new();
    static void Main(string[] args)
    {

  



        int menuChoice = 0;
        do
        {

            Console.WriteLine($"You have {Goal.GetTotalPoints()} points.");
            Console.WriteLine($"\nMenu options");
            Console.WriteLine("1. Creat New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from 1 - 6: ");
            menuChoice = int.Parse(Console.ReadLine());


            if (menuChoice == 1)
            {
                Console.Clear();
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create?  ");
                int goalChoice = int.Parse(Console.ReadLine());

                if (goalChoice == 1)
                {
                    Simple newgoal = new(Goal.InputGoalName(), Goal.InputDescription(), Goal.InputPoints());
                    _goals.Add(newgoal);
                }
                else if (goalChoice == 2)
                {
                    Eternal newgoal = new(Goal.InputGoalName(), Goal.InputDescription(), Goal.InputPoints());
                    _goals.Add(newgoal);
                }
                else if (goalChoice == 3)
                {
                    Checklist newgoal = new(Goal.InputGoalName(), Goal.InputDescription(), Goal.InputPoints(), Checklist.InputTimesToDo(), Checklist.InputBonusPoint());
                    _goals.Add(newgoal);
                }




            }
            else if (menuChoice == 2)
            {
            ListGoals();
                
            }
            else if (menuChoice == 3)
            {
                
            }
            else if (menuChoice == 4)
            {
                
            }
            else if (menuChoice == 5)
            {
                RecordEvent();
            }
            else if (menuChoice == 6)
            {
                Console.WriteLine("Goodbye!");
            }

        } while (menuChoice != 6);

    }

    static void ListGoals()
    {
        Console.WriteLine("Listing goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            if (_goals[i].IsComplete())
            {
                Console.Write("[X] ");
            }
            else
            {
                Console.Write("[ ] ");
            }
            _goals[i].DisplayGoal();
        }

    }
    static void RecordEvent()
    {
        ListGoals();
        Console.Write("Enter the number of the goal you want to record an event for: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            Console.WriteLine("Event recorded!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

        static void SaveGoals()
    {
        string filePath = "goals.json";
        string jsonString = JsonSerializer.Serialize(_goals);
        File.WriteAllText(filePath, jsonString);
        Console.WriteLine("Goals saved to file.");
    }

    static void LoadGoals()
    {
        string filePath = "goals.json";
        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            _goals = JsonSerializer.Deserialize<List<Goal>>(jsonString);
            Console.WriteLine("Goals loaded from file.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

}