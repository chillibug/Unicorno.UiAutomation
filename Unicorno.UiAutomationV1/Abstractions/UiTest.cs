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
        internal ILocatorAssertions Expect(ILocator locator) => Assertions.Expect(locator);

        internal IPageAssertions Expect(IPage page) => Assertions.Expect(page);

        internal IAPIResponseAssertions Expect(IAPIResponse response) => Assertions.Expect(response);
    }
}
