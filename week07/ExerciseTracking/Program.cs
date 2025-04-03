using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold different activities
        List<Activity> activities = new List<Activity>();

        // Create one instance of each activity type:
        // Running: date, duration in minutes, and distance in miles
        activities.Add(new Running(new DateTime(2022, 11, 03), 30, 3.0));

        // Cycling: date, duration in minutes, and speed in mph
        activities.Add(new Cycling(new DateTime(2022, 11, 03), 45, 12.0));

        // Swimming: date, duration in minutes, and number of laps
        activities.Add(new Swimming(new DateTime(2022, 11, 03), 30, 20));

        // Iterate through the list and display the summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
