using System;

interface IShape // Interface defining a contract for shapes
{
    double Area();
}

class Circle : IShape // Circle class implementing the IShape interface
{
    public double Radius;

    public Circle(double r)
    {
        Radius = r;
    }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

// Usage
class Program
{
    static void Main()
    {
        IShape c = new Circle(5);
        Console.WriteLine($"Circle area: {c.Area()}");
    }
}