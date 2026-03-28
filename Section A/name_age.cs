//Section A 
//Q1 Find the name and age of a person

using System;

class Program
{
    static void main(){
            name_and_age();
        }
    static void name_and_age()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hello {name}, you are {age} years old.");
    }
}