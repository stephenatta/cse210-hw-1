using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "Focus on breathing in and out slowly.";
    }

    public override void Run(int duration)
    {
        DisplayStartingMessage(duration);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            AnimationHelper.Countdown(3);
            Console.Write("Breathe out...");
            AnimationHelper.Countdown(3);
        }

        DisplayEndingMessage();
    }
}
