public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordProgress()
    {
        if (!IsComplete)
        {
            CompleteGoal();
            Console.WriteLine($"You completed {Name} and earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"{Name} is already completed.");
        }
    }

    public override string GetGoalInfo()
    {
        return $"{Name} (Simple) - {Points} points";
    }
}
