//Section B
// Q7 Guess the number game

using System;

class Program
{
    static void Main()
    {
        Guess(53);
    }
    static int Guess(int guess)
    {
        Random rand = new Random(); // random number generator
        int target = rand.Next(1, 101);

        int guess;

        while (true)
        {
            if (guess < target)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > target)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("Correct!");

        return guess;
    }
}