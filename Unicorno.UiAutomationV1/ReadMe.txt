Version 1 - Simple scripted testing

Setup Playwright - https://www.twilio.com/blog/test-web-apps-with-playwright-and-csharp-dotnet
				 - https://playwright.dev/dotnet/docs/intro

install package Microsoft.Playwright
dotnet add package Microsoft.Playwright

dotnet build

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