using Microsoft.Playwright;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DynamicTableTests.Pages
{
    public class DynamicTablePage
    {
        private readonly IPage _page;

        public DynamicTablePage(IPage page)
        {
            _page = page;
        }

        // URL
        private string Url => "https://qaplayground.dev/apps/dynamic-table/";

        // Locators
        private ILocator Table => _page.Locator("table");
        private ILocator Rows => _page.Locator("tbody tr");

        // Actions

        public async Task NavigateAsync()
        {
            await _page.GotoAsync(Url);
            await Table.WaitForAsync();
        }

        public async Task<int> GetRowCountAsync()
        {
            return await Rows.CountAsync();
        }

public async Task<IReadOnlyList<string>> GetAllRowsTextAsync()
        {
            return await Rows.AllInnerTextsAsync();
        }

        public async Task<string> GetCpuValueForBrowserAsync(string browserName)
        {
            return await _page
                .Locator($"tbody tr:has-text('{browserName}') td:nth-child(3)")
                .InnerTextAsync();
        }

        public async Task<bool> IsBrowserPresentAsync(string browserName)
        {
            return await _page
                .Locator($"tbody tr:has-text('{browserName}')")
                .CountAsync() > 0;
        }

        public async Task ReplaceBrowserNameAsync(string oldName, string newName)
        {
            await _page.EvaluateAsync($@"
                () => {{
                    const rows = document.querySelectorAll('tbody tr');

                    rows.forEach(row => {{
                        const cell = row.querySelector('td');

                        if (cell && cell.innerText.includes('{oldName}')) {{
                            cell.innerText = '{newName}';
                        }}
                    }});
                }}
            ");
        }
    }
}