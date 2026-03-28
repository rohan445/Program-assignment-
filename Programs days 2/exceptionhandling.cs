using System;

class Program
{
    static void Main()
    {
        exceptionhandle();
    }
    static void exceptionhandle()
    {
        try
        {
            int x = int.Parse("abc"); // will throw FormatException
        }
        catch (FormatException e)
        {
            Console.WriteLine("Invalid format");
        }
        catch (Exception e) // catch-all for any other exceptions
        {
            Console.WriteLine("Some other error");
        }
        finally
        {
            Console.WriteLine("This always runs");
        }
        {
            Console.WriteLine("Some other error");
        }
    }
}