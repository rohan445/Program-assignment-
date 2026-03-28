//Section d 
// Q12 File Handling

using System;
using System.IO; // for file handling

class Program
{
    static void Main()
    {
        Filehandling();
    }
    static void Filehandling()
    {
        Console.Write("Enter sentence: ");
        string text = Console.ReadLine();

        File.WriteAllText("output.txt", text); // write the text to a file named output.txt

        Console.WriteLine("Saved to output.txt");
    }
}