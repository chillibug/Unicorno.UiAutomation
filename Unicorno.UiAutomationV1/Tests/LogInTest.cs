using Microsoft.Playwright;
using Unicorno.UiAutomationV1.Abstractions;

namespace Unicorno.UiAutomationV1.Tests;

public class LogInTest : UiTest
{
    public async Task RunTest(IPage page)
    {
        // Log In to service
        await page.GotoAsync("https://www.saucedemo.com/");

        await Expect(page.Locator("#root")).ToContainTextAsync("Swag Labs");

        await page.Locator("[data-test=\"username\"]").ClickAsync();

        await page.Locator("[data-test=\"username\"]").FillAsync("standard_user");

        await page.Locator("[data-test=\"password\"]").ClickAsync();

        await page.Locator("[data-test=\"password\"]").FillAsync("secret_sauce");

        await page.Locator("[data-test=\"login-button\"]").ClickAsync();


        // Check the page 
        await Expect(page).ToHaveURLAsync("https://www.saucedemo.com/inventory.html");
    }


}
