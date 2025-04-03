using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore;

    public GoalManager()
    {
        totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
        Console.WriteLine($"Goal {goal.Name} added!");
    }

    public void RecordGoalProgress()
    {
        Console.WriteLine("Enter the number of the goal to record progress:");
        DisplayGoals();
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        goals[goalIndex].RecordProgress();
        totalScore += goals[goalIndex].Points;
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetGoalInfo()}");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetGoalInfo());
            }
            writer.WriteLine($"Total Score: {totalScore}");
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("No saved data found.");
        }
    }

    public void DisplayTotalScore()
    {
        Console.WriteLine($"Your total score is: {totalScore}");
    }
}
