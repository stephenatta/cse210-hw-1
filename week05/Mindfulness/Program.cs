using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true)
        {
            Console.WriteLine("\nSelect an activity:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Exercise");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();

            if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            Console.Write("Enter duration in seconds: ");
            if (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0)
            {
                Console.WriteLine("Invalid duration. Please enter a positive number.");
                continue;
            }

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(duration),
                "2" => new ReflectionActivity(duration),
                "3" => new ListingActivity(duration),
                _ => null
            };

            if (activity != null)
            {
                activity.Run();
                ActivityLog.SaveToLog(activity.GetName(), duration);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }
    }
}

/*
 * - EXCEEDED REQUIREMENTS:
 * - Added logging: Activities are saved to 'activity_log.txt' after each session.
 * - Dynamic duration: Users can set their own duration for activities.
 * - Improved randomization: Reflection prompts do not repeat until all are used.
 * - Enhanced animations: Breathing activity text smoothly expands and contracts.
 */
