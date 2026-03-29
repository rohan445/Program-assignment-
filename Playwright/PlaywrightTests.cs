using Xunit;
using Microsoft.Playwright;
using System.Threading.Tasks;

public class PlaywrightTests
{
    [Fact]
    public async Task OpenGoogle()
    {
        using var playwright = await Playwright.CreateAsync();

        var browser = await playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions { Headless = false });

        var page = await browser.NewPageAsync();

        await page.GotoAsync("https://www.google.com");

        Assert.NotNull(page);

        await browser.CloseAsync();
    }
}