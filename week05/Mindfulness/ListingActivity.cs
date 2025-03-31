using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    public ListingActivity(int duration)
        : base("Listing Exercise", "List as many positive things as possible.", duration) { }

    public override void Run()
    {
        DisplayStartingMessage();
        List<string> responses = new();

        Console.WriteLine("Start listing:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {responses.Count} items!");
        DisplayEndingMessage();
    }
}
