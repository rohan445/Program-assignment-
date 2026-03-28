// Section C
//  Q10 This program calculates the percentage and grade based on marks entered by the user.

using System;

class Program
{
    static void Main()
    {
        MarksAndGrades();
    }
    static void MarksAndGrades()
    {
        int[] marks = new int[5];
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter marks: ");
            marks[i] = int.Parse(Console.ReadLine());
            sum += marks[i];
        }

        double percentage = sum / 5.0;
        char grade;

        if (percentage >= 90) {
            grade = 'A';
        }
        else if (percentage >= 75) {
            grade = 'B';\
            }
        else if (percentage >= 50) {
            grade = 'C';
        }
        else {
            grade = 'D';
        }

        Console.WriteLine("Percentage: " + percentage);
        Console.WriteLine("Grade: " + grade);
    }
}