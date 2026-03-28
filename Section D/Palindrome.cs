//section d
//Q11 check if a word is palindrome or not

using System;

class Program
{
    static void Main()
    {
        CheckPalindrome();
    }
    static void CheckPalindrome()
    {
        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        char[] arr = word.ToCharArray(); //convert string to char array
        Array.Reverse(arr);

        string reversed = new string(arr); //convert char array to string

        if (word == reversed)
        {
            Console.WriteLine("Palindrome");
        }

        else
        {
            Console.WriteLine("Not Palindrome");
        }
    }
}