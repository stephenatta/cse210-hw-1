using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();

        // Add different shapes to the list
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 5, 6));
        shapes.Add(new Circle("Green", 3));

        // Loop through each shape and display its color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}
