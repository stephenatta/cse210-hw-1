using System;

class Program
{
    static void Main(string[] args)
    {


    Random randomGenerator = new Random();
    
    int mNumber = randomGenerator.Next(1, 101); // Generate a random number between 1 and 100
    int guess = -1; // Initialize guess to a value that does not match magicNumber
    int guesscount = 0; // Initialize a counter for the number of guesses

    Console.WriteLine("Choose the magic number from 1 - 100 to win the game. ");

    while (guess != mNumber) //while loop
    {

        Console.Write("What is your guess? ");
        string guessNumber = Console.ReadLine();
        guess = int.Parse(guessNumber);

        guesscount++; // Increment the counter with each guess

        if (guess < mNumber)
        {
            Console.WriteLine("Higher");
        }

        else if (guess > mNumber)
        {
            Console.WriteLine("Lower");
        }

        else
        {
            Console.Write("You guessed it! ");
            Console.WriteLine($"(It took you {guesscount} attemp(s).)");
        }
    }

    }
   
    
}