using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter = "";
        

        if (grade >= 90)
        {
            letter = ("A");
            
        }

        else if (grade >= 80)
        {
            letter = ("B");
        }
    
        else if (grade >= 70)
        {
            letter = ("C");
        }
       
        else if (grade >= 60)
        {
            letter = ("D");
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($" Your grade is: {letter}");

        //showing remark
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! you pass the course!");
        }

        else
        {
            Console.WriteLine("Sit up! next time.");
        }

        //Adding + and - sign to grade.
        string  sign = "";
        int lastNumber = grade % 10;

        if (lastNumber >= 7)
        {
            sign = "+";
        }

        else if (lastNumber < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";      
        }

        //remove sign if letter is "A"
        //-----------------------------
        if (grade >= 93)
        {
            sign = "";
        }

        //remove sign if letter is "F"
        //-----------------------------
        if (letter == "F")
        {
            sign = "";
        }


        Console.WriteLine($" Your letter grade is: {letter}{sign}");







    }
}