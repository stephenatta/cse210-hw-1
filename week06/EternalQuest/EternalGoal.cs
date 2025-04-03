public class EternalGoal : Goal
{
    private int progress;

    public EternalGoal(string name, int points) : base(name, points)
    {
        progress = 0;
    }

    public override void RecordProgress()
    {
        progress++;
        Console.WriteLine($"You earned {Points} points for recording progress on {Name}.");
    }

    public override string GetGoalInfo()
    {
        return $"{Name} (Eternal) - Completed {progress} times, {Points} points per entry";
    }
}
