//Section E 
// This code defines a Car class with properties for Brand, Model, and Year, and a method to display this information. The Main method creates an instance of the Car class, sets its properties, and calls the DisplayInfo method to print the car's details to the console.

using System;

class Car
{
    public string brand;
    public string model;
    public int year;
    public Car(string brand, string model, int year) //
    {
        this.brand = brand; 
        this.model = model;
        this.year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{brand} {model} ({year})");
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car("Toyota", "Camry", 2022);
        Car car2 = new Car("Honda", "Civic", 2021);

        car1.DisplayInfo();
        car2.DisplayInfo();
    }
}