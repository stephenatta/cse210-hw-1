// Program.cs - Runs the scripture memorization program
using System;

class Program
{
    static void Main()
    {
        // Create a scripture reference
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        
        // Scripture text
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";

        // Create a scripture instance
        Scripture scripture = new Scripture(reference, scriptureText);

        Console.Clear();
        Console.WriteLine("Scripture Memorization Program");
        Console.WriteLine("-----------------------------------");

        // Main loop for scripture memorization
        while (true)
        {
            Console.WriteLine("\n" + scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("Exiting program...");
                break;
            }

            scripture.HideRandomWords(2); // Hide 2 words per round

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden! Well done.");''
                break;
            }

            Console.Clear(); // Clears screen for better display
        }
    }
}
