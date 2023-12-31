using Microsoft.Playwright;
using Unicorno.UiAutomationV1.Abstractions;

namespace Unicorno.UiAutomationV1.Tests;

public class BuyItemTest : UiTest
{
    public async void RunTest(IPage page)
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

        await Expect(page.Locator("#header_container")).ToContainTextAsync("Products");

        await page.Locator("#item_4_img_link").ClickAsync();

        await Expect(page.Locator("[data-test=\"back-to-products\"]")).ToBeVisibleAsync();

        await Expect(page.Locator("#inventory_item_container")).ToContainTextAsync("Sauce Labs Backpack");

        await Expect(page.Locator("[data-test=\"add-to-cart-sauce-labs-backpack\"]")).ToContainTextAsync("Add to cart");


        // Add Product
        await page.Locator("[data-test=\"add-to-cart-sauce-labs-backpack\"]").ClickAsync();

        // Check
        await Expect(page.Locator("span")).ToContainTextAsync("1");



        //await Expect(page.Locator("[data-test=\"remove-sauce-labs-backpack\"]")).ToContainTextAsync("Remove");

        //await page.Locator("[data-test=\"remove-sauce-labs-backpack\"]").ClickAsync();


        // Go to cart
        await page.Locator("a").Filter(new() { HasText = "1" }).ClickAsync();

        await Expect(page.Locator("#header_container")).ToContainTextAsync("Your Cart");

        await page.GetByRole(AriaRole.Link, new() { Name = "Sauce Labs Backpack" }).ClickAsync();

        await page.Locator("a").Filter(new() { HasText = "1" }).ClickAsync();

        await Expect(page.Locator("#item_4_title_link")).ToContainTextAsync("Sauce Labs Backpack");

        await Expect(page.Locator("#cart_contents_container")).ToContainTextAsync("1");

        await Expect(page.Locator("#cart_contents_container")).ToContainTextAsync("$29.99");

        await page.CloseAsync();
    }
}
