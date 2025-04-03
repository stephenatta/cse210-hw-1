using System;

public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool IsComplete { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsComplete = false;
    }

    public abstract void RecordProgress();
    public abstract string GetGoalInfo();

    public void CompleteGoal()
    {
        IsComplete = true;
    }
}
