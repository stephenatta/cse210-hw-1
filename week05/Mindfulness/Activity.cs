using System;
using System.Threading;

abstract class Activity
{
    protected string Name { get; set; }
    protected string Description { get; set; }

    public void DisplayStartingMessage(int duration)
    {
        Console.Clear();
        Console.WriteLine($"Starting {Name} for {duration} seconds...");
        Console.WriteLine(Description);
        Console.WriteLine("Get ready...");
        Thread.Sleep(2000);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You completed {Name}.");
        LogHelper.LogActivity(Name);
        Thread.Sleep(2000);
    }

    public abstract void Run(int duration);
}
