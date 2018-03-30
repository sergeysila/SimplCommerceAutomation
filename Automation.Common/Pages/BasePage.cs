using System.ComponentModel;
using System.Drawing;
using Automation.Common.Helpers;
using HtmlElements.Elements;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation.Common.Pages
{
    public class BasePage : HtmlPage
    {
        protected static IWebDriver Driver => DriverFactory.GetDriverInstance().Driver;

//        private static T GetPage<T>() where T : new()
//        {
//            var page = new T();
//            PageFactory.InitElements(Driver, page);
//            return page;
//        }

        [FindsBy(How = How.CssSelector, Using = "top-bar"), CacheLookup]
        public TopBar TopBar;

        [FindsBy(How = How.CssSelector, Using = "main-header")]
        public Header Header;

        [FindsBy(How = How.CssSelector, Using = "main-menu")]
        public MainMenu MainMenu;

        [FindsBy(How = How.CssSelector, Using = ".footer-content")]
        public Footer Footer;

        protected BasePage() : base(Driver)
        {
        }
    }

    public class Header : HtmlElement
    {
        [FindsBy(How = How.XPath, Using = "//img[@src,\"modules/core/Logo_SimplCommerce.png\"]")]
        public Image Image;

        [FindsBy(How = How.CssSelector, Using = ".form-inline")]
        public MainSearch Search;

        [FindsBy(How = How.CssSelector, Using = ".cart-badge a")]
        public HtmlLabel CartBadge;

        public Header(IWebElement webElement) : base(webElement)
        {
        }
    }

    public class MainMenu : HtmlElement
    {
        [FindsBy(How = How.XPath, Using = "//ul[@class='nav navbar-nav main-menu']//a[text()='Phones']")]
        HtmlSelect Phones;

        [FindsBy(How = How.XPath, Using = "//ul[@class='nav navbar-nav main-menu']//a[text()='Tablets']")]
        HtmlSelect Tablets;

        [FindsBy(How = How.XPath, Using = "//ul[@class='nav navbar-nav main-menu']//a[text()='Computers']")]
        HtmlSelect Computers;

        [FindsBy(How = How.XPath, Using = "//ul[@class='nav navbar-nav main-menu']//a[text()='Accessories']")]
        HtmlSelect Accessories;

        public MainMenu(IWebElement webElement) : base(webElement)
        {
        }
    }

    public class Footer : HtmlElement
    {
        [FindsBy(How = How.PartialLinkText, Using = "help-center")]
        public HtmlLink HelpCenter;

        [FindsBy(How = How.PartialLinkText, Using = "help-center/how-to-buy")]
        public HtmlLink HowToBuy;

        [FindsBy(How = How.PartialLinkText, Using = "help-center/shipping")]
        public HtmlLink Shipping;

        [FindsBy(How = How.PartialLinkText, Using = "help-center/how-to-return")]
        public HtmlLink HowToReturn;

        [FindsBy(How = How.PartialLinkText, Using = "help-center/warranty")]
        public HtmlLink Warranty;

        [FindsBy(How = How.PartialLinkText, Using = "about-us")]
        public HtmlLink AboutUs;

        [FindsBy(How = How.PartialLinkText, Using = "terms-of-use")]
        public HtmlLink TermsOfUse;

        [FindsBy(How = How.PartialLinkText, Using = "privacy")]
        public HtmlLink Privacy;

        public Footer(IWebElement webElement) : base(webElement)
        {
        }
    }

    public class MainSearch : HtmlElement
    {
        [FindsBy(How = How.CssSelector, Using = ".search-input input")]
        public HtmlInput SearchInput;

        [FindsBy(How = How.Id, Using = "Category")]
        public HtmlSelect SearchCategorySelector;

        [FindsBy(How = How.CssSelector, Using = ".search-btn")]
        public HtmlLabel SearchButon;

        public MainSearch(IWebElement webElement) : base(webElement)
        {
        }
    }

    public class TopBar : HtmlElement
    {
        [FindsBy(How = How.CssSelector, Using = ".lang-selector")]
        public HtmlSelect LangSelectors;

        [FindsBy(How = How.PartialLinkText, Using = "login")]
        public HtmlLink Login;

        [FindsBy(How = How.PartialLinkText, Using = "register")]
        public HtmlLink Register;

        public TopBar(IWebElement webElement) : base(webElement)
        {
        }
    }
}