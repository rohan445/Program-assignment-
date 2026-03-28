//Section B
// Q4 Sum of N natural numbers

using System;

class Program
{
    static void Main()
    {
        addition();
    }

    static int addition()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= n; i++)
            sum += i;

        Console.WriteLine("Sum = " + sum);

        return sum;
    }
}