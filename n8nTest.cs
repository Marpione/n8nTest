using System;

class Circle
{
    public double GetCircumference(double radius)
    {
        return 2 * 3.14159 * radius; // Magic number: 3.14159
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle();
        double circumference = circle.GetCircumference(10); // Magic number: 10
        Console.WriteLine("Circumference: " + circumference);
    }
}
