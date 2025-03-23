// Handles user interaction and manages journal operations.
// EXTRA FEATURE: Users can enter a filename of their choice when saving and loading journal entries.
// This allows greater flexibility instead of using a fixed file name.
// Additionally, the program includes structured error handling when loading a non-existent file.
// Handles user interaction and manages journal operations.
using System;

class Program
{
    static void Main(string[] args)
     {
        Journal myJournal = new Journal();
        
        while (true)
        {
            Console.WriteLine("Journal Program - Choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();
            Console.WriteLine();
            
            switch (choice)
            {
                case "1":
                    myJournal.AddEntry();
                    break;
                case "2":
                    myJournal.DisplayJournal();
                    break;
                case "3":
                    myJournal.SaveToFile();
                    break;
                case "4":
                    myJournal.LoadFromFile();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }
}