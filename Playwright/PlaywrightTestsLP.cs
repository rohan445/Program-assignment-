using Xunit;
using System;
using Microsoft.Playwright;
using System.Threading.Tasks;

class Tests
{
    [Fact]
    public async Task LoginTest()
    {
        using var playwright = await playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new LaunchOptions
        {
            Headless = true
        });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://the-internet.herokuapp.com/login");
        await page.FillAsync("#username", "Username");
        await page.FillAsync("#password", "Password");
        await page.ClickAsync("button[type='submit']");
        var successMessage = await page.InnerTextAsync("#flash");
        Assert.Contains("You logged into a secure area!", successMessage);
        await browser.CloseAsync();

    }


}