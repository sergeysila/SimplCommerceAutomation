using System.Drawing;
using Ipreo.AutomationFramework.UI.Components.Search;

namespace Automation.Common.Pages.HomePg
{
    public class HomePage : BasePage
    {
        [FindBy(How.CssSelector, "logo img")] 
        public Image LogoImage;
    }
}