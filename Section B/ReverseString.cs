//Section B
// Q5 Reverse a string

using System;

class Program
{
    static void Main()
    {
        ReverseString();
    }
    static void ReverseString()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        char[] arr = input.ToCharArray();// Convert string to char array 
        Array.Reverse(arr); // Reverse the char array 

        Console.WriteLine("Reversed: " + new string(arr));
;
    }
}