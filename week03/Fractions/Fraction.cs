// Fraction.cs - Implements encapsulation for a fraction class
using System;

public class Fraction
{
    // Private attributes (Encapsulation)
    private int _numerator;
    private int _denominator;

    // Default constructor (1/1)
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with one parameter (e.g., 5 -> 5/1)
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor with two parameters (e.g., 3/4)
    public Fraction(int numerator, int denominator)
    {
        if (denominator != 0)
        {
            _numerator = numerator;
            _denominator = denominator;
        }
        else
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    // Getter for Numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    // Setter for Numerator
    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Getter for Denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    // Setter for Denominator (Prevents division by zero)
    public void SetDenominator(int denominator)
    {
        if (denominator != 0)
        {
            _denominator = denominator;
        }
        else
        {
            Console.WriteLine("Error: Denominator cannot be zero.");
        }
    }

    // Method to return fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return decimal value of fraction (e.g., 0.75)
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
