using Microsoft.Playwright;
using System.Threading.Tasks;

namespace DynamicTableTests.Utils
{
    public class PlaywrightFactory
    {
        private IPlaywright _playwright = null!;
        private IBrowser _browser = null!;
        private IBrowserContext _context = null!;
        private IPage _page = null!;

        public IPage Page => _page;

        public async Task InitAsync(bool headless = false)
        {
            _playwright = await Playwright.CreateAsync();

            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = headless,
                SlowMo = 50 // optional: helps debugging
            });

            _context = await _browser.NewContextAsync(new BrowserNewContextOptions
            {
                ViewportSize = new ViewportSize
                {
                    Width = 1280,
                    Height = 720
                }
            });

            _page = await _context.NewPageAsync();
        }

        public async Task CloseAsync()
        {
            if (_context != null)
                await _context.CloseAsync();

            if (_browser != null)
                await _browser.CloseAsync();

            _playwright?.Dispose();
        }
    }
}