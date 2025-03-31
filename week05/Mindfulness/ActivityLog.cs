using System;
using System.IO;

static class ActivityLog
{
    private const string FilePath = "activity_log.txt";

    public static void SaveToLog(string activityName, int duration)
    {
        using StreamWriter writer = new(FilePath, append: true);
        writer.WriteLine($"{DateTime.Now}: {activityName} - {duration} sec");
    }
}
