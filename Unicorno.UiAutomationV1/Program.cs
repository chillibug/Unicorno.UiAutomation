// See https://aka.ms/new-console-template for more information
using Microsoft.Playwright;
using System.Reflection;
using Unicorno.UiAutomationV1.Tests;



using var playwright = await Playwright.CreateAsync();
await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
{
    Headless = false,
    SlowMo = 1000
});

var context = await browser.NewContextAsync();
var page = await browser.NewPageAsync();


// Integration tests
await (new LogInTest()).RunTest(page);
await (new AddItemToCartTest()).RunTest(page);
await (new BuyItemTest()).RunTest(page);



Console.ReadLine();
