using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "List as many things as you can related to a given prompt.";
    }

    public override void Run(int duration)
    {
        DisplayStartingMessage(duration);

        Console.WriteLine("List things you are grateful for:");
        Console.WriteLine($"You have {duration} seconds. Start typing...");

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                responses.Add(input);
        }

        Console.WriteLine($"You listed {responses.Count} items.");
        DisplayEndingMessage();
    }
}
