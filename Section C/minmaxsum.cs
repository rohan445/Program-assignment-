//Section C
/* Q9 program that takes 5 numbers as input and checks for the minimum, maximum, 
and average of those numbers.*/

using System;

class Program
{
    static void Main()
    {
        checkminmaxsum();
    }

    static void checkminmaxsum()
    {
        int[] nums = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number: ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        int max = nums[0], min = nums[0], sum = 0;

        foreach (int n in nums)
        {
            if (n > max) max = n;
            if (n < min) min = n;
            sum += n;
        }

        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Average: " + (sum / 5.0));
    }
}