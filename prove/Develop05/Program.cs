using System;

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
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create?");
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
                    Checklist newgoal = new(Goal.InputGoalName(), Goal.InputDescription(), Goal.InputPoints(), Checklist.InputTimesToDo());
                    _goals.Add(newgoal);
                }




            }
            else if (menuChoice == 2)
            {
                Console.WriteLine("The goals are: ");
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.Write($"{i}.");
                    if (_goals[i].IsComplete())
                    {
                        Console.Write("[X]");
                    }else
                    {
                        Console.Write("[]");
                    }
                }
                
            }
            else if (menuChoice == 3)
            {
                
            }
            else if (menuChoice == 4)
            {
                
            }
            else if (menuChoice == 5)
            {
                
            }
            else if (menuChoice == 6)
            {
                Console.WriteLine("Goodbye!");
            }

        } while (menuChoice != 6);
    }
}