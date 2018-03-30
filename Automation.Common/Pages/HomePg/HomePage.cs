using System.Drawing;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation.Common.Pages.HomePg
{
    public class HomePage : BasePage
    {
        [FindsBy(How=How.CssSelector, Using = "logo img")] 
        public Image LogoImage;
    }
}