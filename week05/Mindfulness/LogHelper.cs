using System;
using System.IO;

static class LogHelper
{
    private static string logFile = "activity_log.txt";

    public static void LogActivity(string activityName)
    {
        string logEntry = $"{DateTime.Now}: {activityName}\n";
        File.AppendAllText(logFile, logEntry);
    }

    public static void ShowLog()
    {
        if (File.Exists(logFile))
        {
            string logContent = File.ReadAllText(logFile);
            Console.WriteLine("Activity Log:");
            Console.WriteLine(logContent);
        }
        else
        {
            Console.WriteLine("No log file found.");
        }
    }
}
