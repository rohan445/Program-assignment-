// Section B
// Q5 Multiplication table of a number

using System;

class Program
{
    static void Main()
    {
        Multiply();
    }
    static int Multiply()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{n} x {i} = {n * i}");

        return 0;
    }
}