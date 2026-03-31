using Microsoft.Playwright;
using System;
using System.Threading.Tasks;
using DynamicTableTests.Pages; 

namespace DynamicTableTests.Tests
{
    public class DynamicTableTestRunner
    {
        public static async Task Run()
        {
            using var playwright = await Playwright.CreateAsync();

            var browser = await playwright.Chromium.LaunchAsync(new()
            {
                Headless = false
            });

            var page = await browser.NewPageAsync();

            var tablePage = new DynamicTablePage(page);

            await tablePage.NavigateAsync();

            // ✅ Test 1: Validate table loads
            int rowCount = await tablePage.GetRowCountAsync();
            Console.WriteLine($"Row Count: {rowCount}");

            // ✅ Test 2: Get Chrome CPU value
            var cpu = await tablePage.GetCpuValueForBrowserAsync("Chrome");
            Console.WriteLine($"Chrome CPU: {cpu}");

            // ✅ Test 3: Find Spiderman
            bool found = await tablePage.IsBrowserPresentAsync("Spiderman");
            Console.WriteLine($"Spiderman Found: {found}");

            // ✅ Test 4: Replace Spiderman
            if (found)
            {
                await tablePage.ReplaceBrowserNameAsync("Spiderman", "Peter Parker");
                Console.WriteLine("Replaced Spiderman ✅");
            }

            await browser.CloseAsync();
        }
    }
}