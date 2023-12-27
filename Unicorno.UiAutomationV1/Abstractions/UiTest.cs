using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorno.UiAutomationV1.Abstractions
{
    public abstract class UiTest
    {
        private static ILocatorAssertions Expect(ILocator locator) => Assertions.Expect(locator);

        private static IPageAssertions Expect(IPage page) => Assertions.Expect(page);

        private static IAPIResponseAssertions Expect(IAPIResponse response) => Assertions.Expect(response);
    }
}
