using System;

class Program
{
    // Main entry point of the program
    static void Main(string[] args)
    {
        // Creating an instance of the GoalManager class to manage goals and user progress
        GoalManager goalManager = new GoalManager();
        string filename = "goals.txt";  // File name where goals and progress will be saved/loaded

        // Main program loop that keeps the application running until the user chooses to exit
        while (true)
        {
            Console.Clear();  // Clears the console for each iteration to keep the UI clean
            Console.WriteLine("Welcome to the Eternal Quest Program!");  // Program welcome message
            Console.WriteLine("1. Add a Goal");
            Console.WriteLine("2. Record Goal Progress");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Total Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            
            // Reading user's choice for the action they want to take
            int option = int.Parse(Console.ReadLine());

            // Switch statement to handle the user's choice
            switch (option)
            {
                case 1:
                    // Adding a new goal based on user input
                    Console.WriteLine("Enter Goal Type (Simple, Eternal, Checklist): ");
                    string goalType = Console.ReadLine().ToLower();  // Takes user input for goal type

                    // Asking for goal details like name and points
                    Console.Write("Enter Goal Name: ");
                    string goalName = Console.ReadLine();

                    Console.Write("Enter Points: ");
                    int points = int.Parse(Console.ReadLine());

                    // Based on goal type, we create a different kind of goal using polymorphism
                    if (goalType == "simple")
                    {
                        // Creating and adding a SimpleGoal to the goal manager
                        goalManager.AddGoal(new SimpleGoal(goalName, points));
                    }
                    else if (goalType == "eternal")
                    {
                        // Creating and adding an EternalGoal to the goal manager
                        goalManager.AddGoal(new EternalGoal(goalName, points));
                    }
                    else if (goalType == "checklist")
                    {
                        // Creating and adding a ChecklistGoal to the goal manager
                        Console.Write("Enter Target Count: ");
                        int targetCount = int.Parse(Console.ReadLine());
                        Console.Write("Enter Bonus Points: ");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        goalManager.AddGoal(new ChecklistGoal(goalName, points, targetCount, bonusPoints));
                    }
                    break;

                case 2:
                    // Recording progress for a specific goal
                    goalManager.RecordGoalProgress();
                    break;

                case 3:
                    // Displaying all the current goals and their statuses
                    goalManager.DisplayGoals();
                    break;

                case 4:
                    // Displaying the total score that the user has accumulated
                    goalManager.DisplayTotalScore();
                    break;

                case 5:
                    // Saving the current goals and the total score to a file
                    goalManager.SaveGoals(filename);
                    Console.WriteLine("Goals saved!");
                    break;

                case 6:
                    // Loading and displaying previously saved goals and progress from the file
                    goalManager.LoadGoals(filename);
                    break;

                case 7:
                    // Exiting the program
                    return;

                default:
                    // In case the user enters an invalid option
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            // Prompt the user to press any key to continue after each action
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();  // Pauses the program until the user presses a key
        }
    }
}
