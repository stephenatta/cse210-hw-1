using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new BreathingActivity(),
            new ReflectionActivity(),
            new ListingActivity()
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Show Log");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "5")
                break;

            if (choice == "4")
            {
                LogHelper.ShowLog();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                continue;
            }

            if (int.TryParse(choice, out int index) && index >= 1 && index <= 3)
            {
                Console.Write("Enter duration in seconds: ");
                if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
                {
                    activities[index - 1].Run(duration);
                }
                else
                {
                    Console.WriteLine("Invalid duration. Please enter a positive number.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
