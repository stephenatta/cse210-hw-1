// EXTRA FEATURE: 
// 1. Users can enter their own scriptures.
// 2. Difficulty levels allow hiding 1, 3, or 5 words at a time.
// 3. Words are hidden randomly instead of sequentially.
// 4. The program saves progress so users can resume later.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Do you want to enter a scripture manually? (yes/no)");
        string choice = Console.ReadLine().Trim().ToLower();

        Reference reference;
        string scriptureText;

        if (choice == "yes")
        {
            Console.Write("Enter Book Name: ");
            string book = Console.ReadLine();

            Console.Write("Enter Chapter: ");
            int chapter = int.Parse(Console.ReadLine());

            Console.Write("Enter Verse (or start verse for a range): ");
            int startVerse = int.Parse(Console.ReadLine());

            Console.Write("Enter End Verse (or press enter if it's a single verse): ");
            string endVerseInput = Console.ReadLine();
            int endVerse = string.IsNullOrEmpty(endVerseInput) ? -1 : int.Parse(endVerseInput);

            Console.Write("Enter Scripture Text: ");
            scriptureText = Console.ReadLine();

            reference = new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            reference = new Reference("John", 3, 16);
            scriptureText = "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life.";
        }

        Scripture scripture = new Scripture(reference, scriptureText);

        Console.WriteLine("Select Difficulty Level: (1) Easy (2) Medium (3) Hard");
        int difficulty = int.Parse(Console.ReadLine());
        int wordsToHide = difficulty switch
        {
            1 => 1,  // Easy: 1 word at a time
            2 => 3,  // Medium: 3 words at a time
            3 => 5,  // Hard: 5 words at a time
            _ => 1
        };

        while (true)
        {
            scripture.DisplayScripture();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                SaveProgress(reference.GetReferenceText(), scriptureText);
                break;
            }

            scripture.HideWords(wordsToHide);

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden! Great job!");
                SaveProgress(reference.GetReferenceText(), scriptureText);
                break;
            }
        }
    }

    static void SaveProgress(string reference, string scriptureText)
    {
        string filePath = "scripture_progress.txt";
        File.WriteAllText(filePath, $"{reference}\n{scriptureText}");
        Console.WriteLine($"Progress saved to {filePath}.");
    }
}
