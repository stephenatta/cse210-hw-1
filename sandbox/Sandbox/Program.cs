using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter a number ");
        string valueFromUser = Console.ReadLine();


        int x = int.Parse(valueFromUser);
        int y = 20;

        if (x > y)
        {
            Console.WriteLine("Greater");
        }
        else if (x < y)
        {
            Console.WriteLine("Less");
        }
        else
        {
            Console.WriteLine("Equal");
        }


    }
}