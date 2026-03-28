import re 
import playwright.sync_api as Page

def test_example(page:Page):
    page.goto("https://www.youtube.com")
    

