using System;
using System.Net.Http; // Namespace for HttpClient
using System.Threading.Tasks; // Program to demonstrate asynchronous HTTP request using HttpClient

class Program
{
    static async Task Main()
    {
        using HttpClient client = new HttpClient();

        Console.WriteLine("Fetching post data...");
        string response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1"); 
        // Asynchronous call to fetch data from API
        Console.WriteLine("Received:");
        Console.WriteLine(response);
    }
}