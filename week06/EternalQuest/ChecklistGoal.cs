public class ChecklistGoal : Goal
{
    private int currentCount;
    private int targetCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        currentCount = 0;
    }

    public override void RecordProgress()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            Console.WriteLine($"You earned {Points} points for recording progress on {Name}. Completed {currentCount}/{targetCount}.");
        }
        if (currentCount == targetCount)
        {
            CompleteGoal();
            Console.WriteLine($"Congratulations! You've completed {Name} and earned a bonus of {bonusPoints} points!");
        }
    }

    public override string GetGoalInfo()
    {
        return $"{Name} (Checklist) - Completed {currentCount}/{targetCount} times, {Points} points each, bonus of {bonusPoints} at completion.";
    }
}
