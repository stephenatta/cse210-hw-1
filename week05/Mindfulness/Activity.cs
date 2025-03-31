using System;
using System.Threading;

abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName() => _name;
    public string GetDescription() => _description;

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nStarting {_name}...");
        Console.WriteLine(_description);
        Console.WriteLine("Get ready...");
        AnimationHelper.ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done! You completed {_name} for {_duration} seconds.");
        AnimationHelper.ShowSpinner(3);
    }

    public abstract void Run();
}
