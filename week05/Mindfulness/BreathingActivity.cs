using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity(int duration)
        : base("Breathing Exercise", "Focus on your breath as you inhale and exhale.", duration) { }

    public override void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration / 4; i++)
        {
            Console.Write("Breathe in... ");
            AnimationHelper.ShowGrowingText();
            Console.Write("Breathe out... ");
            AnimationHelper.ShowShrinkingText();
        }

        DisplayEndingMessage();
    }
}
