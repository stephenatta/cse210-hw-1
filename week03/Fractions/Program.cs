// Program.cs - Tests the Fraction class
using System;

class Program
{
    static void Main()
    {
        // Test default constructor (1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString()); // Expected: "1/1"
        Console.WriteLine(f1.GetDecimalValue());  // Expected: 1.0

        // Test constructor with one parameter (e.g., 5 -> 5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString()); // Expected: "5/1"
        Console.WriteLine(f2.GetDecimalValue());  // Expected: 5.0

        // Test constructor with two parameters (e.g., 3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString()); // Expected: "3/4"
        Console.WriteLine(f3.GetDecimalValue());  // Expected: 0.75

        // Test setter methods
        f3.SetNumerator(1);
        f3.SetDenominator(3);
        Console.WriteLine(f3.GetFractionString()); // Expected: "1/3"
        Console.WriteLine(f3.GetDecimalValue());  // Expected: 0.3333...

        // Test setting an invalid denominator (should print an error message)
        f3.SetDenominator(0);  // Should not update the value
        Console.WriteLine(f3.GetFractionString()); // Expected: "1/3" (unchanged)
    }
}
