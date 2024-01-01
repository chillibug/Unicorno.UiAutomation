Version 1 - Simple scripted testing

This is a basic set of tests recorded using playwright and demonstrate how playwright automation
works. There is some simple code abstraction to make each test eaier to read.

Setup Playwright - https://www.twilio.com/blog/test-web-apps-with-playwright-and-csharp-dotnet
				 - https://playwright.dev/dotnet/docs/intro

install package Microsoft.Playwright
dotnet add package Microsoft.Playwright

dotnet build

https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-windows?view=powershell-7.4

pwsh bin/Debug/net8.0/playwright.ps1 install

add a bunch of code
using var playwright = await Playwright.CreateAsync();
await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
{
    Headless = false,
    SlowMo = 500
});

var context = await browser.NewContextAsync();
var page = await browser.NewPageAsync();



RECORD TESTS

$env:PWDEBUG=1

run app

Record tests



ADD THE EXPECTS

    public static class LogInAndAddItemToCartTest
    {
        public static async void RunTest()
        { 
           // script goes here
        }

        public static ILocatorAssertions Expect(ILocator locator) => Assertions.Expect(locator);

        public static IPageAssertions Expect(IPage page) => Assertions.Expect(page);

        public static IAPIResponseAssertions Expect(IAPIResponse response) => Assertions.Expect(response);
    }