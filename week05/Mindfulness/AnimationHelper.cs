using System;
using System.Threading;

static class AnimationHelper
{
    public static void ShowSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{spinner[i++ % spinner.Length]} ");
            Thread.Sleep(200);
        }
        Console.Write("\r  \r"); // Clear spinner
    }

    public static void ShowGrowingText()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"\rBreathe In {new string('.', i)}  ");
            Thread.Sleep(500);
        }
    }

    public static void ShowShrinkingText()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"\rBreathe Out {new string('.', i)}  ");
            Thread.Sleep(500);
        }
    }
}
