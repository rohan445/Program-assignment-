using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose a program to run:");
            Console.WriteLine("1. Sum of N natural numbers");
            Console.WriteLine("2. Guess the number game");
            Console.WriteLine("3. Count vowels in a string");
            Console.WriteLine("4. Multiplication table");
            Console.WriteLine("5. Reverse a string");
            Console.WriteLine("6. Exit");
            Console.Write("Option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    SumProgram.Run();
                    break;
                case "2":
                    GuessNumberProgram.Run();
                    break;
                case "3":
                    CountVowelsProgram.Run();
                    break;
                case "4":
                    MultiplyProgram.Run();
                    break;
                case "5":
                    ReverseStringProgram.Run();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select 1-6.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
