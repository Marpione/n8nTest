using System;

class Circle
{
    private const double Pi = Math.PI; // Use Math.PI for accuracy and readability

    public double GetCircumference(double radius)
    {
        return 2 * Pi * radius; // Replaced magic number with Pi constant
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle();
        double radius = 10; // Extracted magic number to a variable
        double circumference = circle.GetCircumference(radius);
        Console.WriteLine("Circumference: " + circumference);
    }
}