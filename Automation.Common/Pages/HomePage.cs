using Epam.JDI.Core.Interfaces.Common;
using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Composite;

namespace Automation.Common.Pages
{
    public class HomePage : WebPage
    {
        [FindBy(Css = "logo img")] 
        public IImage LogoImage;
    }
}