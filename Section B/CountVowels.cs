//Section B
// Q6 Count the number of vowels in a string


using System;

class Program
{
    static void Main()
    {
        count_vowels();
    }
    static void count_vowels()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        int count = 0;
        foreach (char c in input)
        {
            if ("aeiou".Contains(c) || "AEIOU".Contains(c))
                count++;
        }

        Console.WriteLine("Vowels: " + count);

    }
}