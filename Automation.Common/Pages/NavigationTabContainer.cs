using Automation.Common.Helpers.Extensions;
using Ipreo.AutomationFramework.UI.Components;
using Ipreo.AutomationFramework.UI.Components.Search;

namespace Automation.Common.Pages
{
    public class NavigationTabContainer : Container
    {
        [FindBy(How.Xpath, "//ul[@class='nav navbar-nav main-menu']//a[text()='Phones']")]
        [Titles("PhonesTab")]
        HtmlLabel Phones;
        
        [FindBy(How.Xpath, "//ul[@class='nav navbar-nav main-menu']//a[text()='Tablets']")]
        [Titles("Tablets")]
        HtmlLabel Tablets;
        
        [FindBy(How.Xpath, "//ul[@class='nav navbar-nav main-menu']//a[text()='Computers']")]
        [Titles("Computers")]
        HtmlLabel Computers;
        
        [FindBy(How.Xpath, "//ul[@class='nav navbar-nav main-menu']//a[text()='Accessories']")]
        [Titles("Accessories")]
        HtmlLabel Accessories;

        public void OpenTab(string tabName)
        {
            GetComponent<HtmlDropDown>(tabName).Hover();
            GetComponent<HtmlDropDown>(tabName).Hover();
        }
    }
}