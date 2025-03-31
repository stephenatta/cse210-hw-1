using System;
using System.Threading;

static class AnimationHelper
{
    public static void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($" {i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b\b");
        }
        Console.WriteLine();
    }

    public static void Spinner(int duration)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            foreach (char c in spinner)
            {
                Console.Write(c);
                Thread.Sleep(250);
                Console.Write("\b");
            }
        }
    }
}
