//Section A
//Q3 Build a simple calculator

using System;

class Program
{
    static void main(){
        Calculator();
    }
    static void Calculator()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        char op = Console.ReadLine()[0];

        switch (op)
        {
            case '+': Console.WriteLine(a + b); break;
            case '-': Console.WriteLine(a - b); break;
            case '*': Console.WriteLine(a * b); break;
            case '/':
                if (b != 0) Console.WriteLine(a / b);
                else Console.WriteLine("Cannot divide by zero");
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}