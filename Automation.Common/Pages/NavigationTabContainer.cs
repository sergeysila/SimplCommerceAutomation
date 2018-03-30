using Automation.Common.Helpers.Extensions;
using Ipreo.AutomationFramework.UI.Components;
using Ipreo.AutomationFramework.UI.Components.Search;

namespace Automation.Common.Pages
{
    public class NavigationTabContainer : Container
    {
        [FindsBy(How.Xpath, "//ul[@class='nav navbar-nav main-menu']//a[text()='Phones']")]
        [Titles("PhonesTab")]
        HtmlLabel Phones;
        
        [FindsBy(How.Xpath, "//ul[@class='nav navbar-nav main-menu']//a[text()='Tablets']")]
        [Titles("Tablets")]
        HtmlLabel Tablets;
        
        [FindsBy(How.Xpath, "//ul[@class='nav navbar-nav main-menu']//a[text()='Computers']")]
        [Titles("Computers")]
        HtmlLabel Computers;
        
        [FindsBy(How.Xpath, "//ul[@class='nav navbar-nav main-menu']//a[text()='Accessories']")]
        [Titles("Accessories")]
        HtmlLabel Accessories;

        public void OpenTab(string tabName)
        {
            GetComponent<HtmlDropDown>(tabName).Hover();
            GetComponent<HtmlDropDown>(tabName).Hover();
        }
    }
}