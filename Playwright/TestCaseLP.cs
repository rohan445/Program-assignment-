using System;
using System.Threading.Tasks;
using Microsoft.Playwright; 

namespace playwrightTests
{
    

class Program
{
    public static async Task Main()
    {
        using var playwright = await Playwright.CreateAsync(slowMo: true);

        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false 
        });

        var context = await browser.NewContextAsync();
        var page = await context.NewPageAsync();

        // 1. Navigate to site
        await page.GotoAsync("https://www.saucedemo.com/");

        // 2. Login
        await page.FillAsync("#user-name", "standard_user");
        await page.FillAsync("#password", "secret_sauce");
        await page.ClickAsync("#login-button");

        // Assertion 1
        await page.WaitForSelectorAsync(".inventory_list");

        Console.WriteLine("Login Successful");

        // Add product to cart
        await page.ClickAsync("text=Add to cart"); 
        string cartCount = await page.InnerTextAsync(".shopping_cart_badge");

        if (cartCount != "1")
            throw new Exception("Item not added to cart");

        Console.WriteLine("Item added to cart");

        // 4. Go to cart
        await page.ClickAsync(".shopping_cart_link");

        // Assertion  2
        await page.WaitForSelectorAsync(".cart_item");

        Console.WriteLine("Cart verified");

        // Checkout
        await page.ClickAsync("#checkout");

        // Fill details
        await page.FillAsync("#first-name", "John");
        await page.FillAsync("#last-name", "Doe");
        await page.FillAsync("#postal-code", "110001");

        await page.ClickAsync("#continue");

        // Assertion 3
        await page.WaitForSelectorAsync(".summary_info");

        Console.WriteLine("Checkout info entered");

        // Assertion 4
        await page.WaitForSelectorAsync(".summary_total_label");

        // Finish order
        await page.ClickAsync("#finish");

        // Assertion 5
        string confirmation = await page.InnerTextAsync(".complete-header");

        if (!confirmation.Contains("Thank you"))
            throw new Exception("Order not completed");

        Console.WriteLine("Order completed successfully");

        await browser.CloseAsync();
    }
}

}