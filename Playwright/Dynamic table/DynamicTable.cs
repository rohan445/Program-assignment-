using Microsoft.Playwright;
using System;
using System.Threading.Tasks;

class DynamicTableSample
{
    public static async Task ExecuteAsync()
    {
        using var playwright = await Playwright.CreateAsync();

        var browser = await playwright.Chromium.LaunchAsync(new()
        {
            Headless = false,
            SlowMo = 250
        });

        var page = await browser.NewPageAsync();

        await page.GotoAsync("https://qaplayground.dev/apps/dynamic-table/");
        await page.WaitForTimeoutAsync(1000);

        await page.WaitForSelectorAsync("table");
        await page.WaitForTimeoutAsync(1000);

        // Replace "Spiderman" text in the table row if it exists
        var spiderRow = page.Locator("tbody tr:has-text('Spiderman')");
        if (await spiderRow.CountAsync() > 0)
        {
            await spiderRow.First.EvaluateAsync("row => { const firstCell = row.querySelector('td'); if (firstCell) firstCell.innerText = 'Peter Parker'; }");
        }

        // Verify change
        var updatedText = await page.Locator("tbody tr").AllInnerTextsAsync();

        Console.WriteLine("Updated Table:");
        foreach (var row in updatedText)
        {
            Console.WriteLine(row);
        }

        await browser.CloseAsync();
    }
}