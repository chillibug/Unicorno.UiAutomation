// See https://aka.ms/new-console-template for more information
using Microsoft.Playwright;
using Unicorno.UiAutomationV1.Scripts;



using var playwright = await Playwright.CreateAsync();
await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
{
    Headless = false,
    SlowMo = 1000
});

var context = await browser.NewContextAsync();
var page = await browser.NewPageAsync();


// Long script
LogInAndAddItemToCartTest.RunTest(page);



Console.ReadLine();
