using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think about a time you overcame a challenge.",
        "Recall a moment when you felt truly happy.",
        "Consider a time when you helped someone in need."
    };

    public ReflectionActivity()
    {
        Name = "Reflection Activity";
        Description = "Think deeply about meaningful experiences in your life.";
    }

    public override void Run(int duration)
    {
        DisplayStartingMessage(duration);

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        AnimationHelper.Spinner(duration);

        DisplayEndingMessage();
    }
}
