//section G
// This program checks if a number is prime or not.
using System;

class Program
{
    static void Main()
    {
        CheckPrime(5);
    }
    static int CheckPrime(int n)
    {

        if (n <= 1)
        {
            Console.WriteLine("Not Prime");
            return;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine("Not Prime");
                return;
            }
        }

        Console.WriteLine("Prime");

    }
}