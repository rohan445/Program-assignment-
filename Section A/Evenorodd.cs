//Section A 
// Q2 Find if a number is Even or Odd

using System;

class Program
{
    static void main(){
        EvenorOdd();
    }
    static void EvenorOdd()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }
}