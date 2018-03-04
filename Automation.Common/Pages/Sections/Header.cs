using Epam.JDI.Core.Interfaces.Common;
using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Composite;

namespace Automation.Common.Pages.Sections
{
    public class Header : Section
    {
        [FindBy(XPath = "//img[@src=\"modules/core/Logo_SimplCommerce.png\"]")]
        public IImage Image;

        [FindBy(Css = ".form-inline")]
        public MainSearch Search;

        [FindBy(Css = ".cart-badge a")]
        public IButton CartBadge;
    }
}