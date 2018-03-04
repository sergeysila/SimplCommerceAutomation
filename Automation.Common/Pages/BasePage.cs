using System.Drawing;
using Ipreo.AutomationFramework.UI.Components;
using Ipreo.AutomationFramework.UI.Components.Search;

namespace Automation.Common.Pages
{
    public class BasePage : Page
    {
        [FindBy(How.CssSelector, "top-bar")] public TopBar TopBar;

        [FindBy(How.CssSelector, "main-header")]
        public Header Header;
        
        [FindBy(How.CssSelector, "main-menu")]
        public MainMenu MainMenu;
        
        [FindBy(How.CssSelector, ".footer-content")]
        public Footer Footer;
    }
    
    public class Header : Container
    {
        [FindBy(How.Xpath, "//img[@src,\"modules/core/Logo_SimplCommerce.png\"]")]
        public Image Image;

        [FindBy(How.CssSelector, ".form-inline")]
        public MainSearch Search;

        [FindBy(How.CssSelector, ".cart-badge a")]
        public HtmlButton CartBadge;
    }

    public class MainMenu : Container
    {
        [FindBy(How.Xpath, "//ul[@class='nav navbar-nav main-menu']//a[text()='Phones']")]
        HtmlDropDown Phones;
        
        [FindBy(How.Xpath, "//ul[@class='nav navbar-nav main-menu']//a[text()='Tablets']")]
        HtmlDropDown Tablets;
        
        [FindBy(How.Xpath, "//ul[@class='nav navbar-nav main-menu']//a[text()='Computers']")]
        HtmlDropDown Computers;
        
        [FindBy(How.Xpath, "//ul[@class='nav navbar-nav main-menu']//a[text()='Accessories']")]
        HtmlDropDown Accessories;
    }
    
    public class Footer : Container
    {
        [FindBy(How.PartialLinkText, "help-center")]
        public HtmlLink HelpCenter;

        [FindBy(How.PartialLinkText, "help-center/how-to-buy")]
        public HtmlLink HowToBuy;

        [FindBy(How.PartialLinkText, "help-center/shipping")]
        public HtmlLink Shipping;

        [FindBy(How.PartialLinkText, "help-center/how-to-return")]
        public HtmlLink HowToReturn;

        [FindBy(How.PartialLinkText, "help-center/warranty")]
        public HtmlLink Warranty;

        [FindBy(How.PartialLinkText, "about-us")]
        public HtmlLink AboutUs;

        [FindBy(How.PartialLinkText, "terms-of-use")]
        public HtmlLink TermsOfUse;

        [FindBy(How.PartialLinkText, "privacy")]
        public HtmlLink Privacy;
    }


    public class MainSearch : Container
    {
        [FindBy(How.CssSelector, ".search-input input")]
        public HtmlTextField SearchInput;

        [FindBy(How.Id, "Category")] 
        public HtmlDropDown SearchCategorySelector;

        [FindBy(How.CssSelector, ".search-btn")]
        public HtmlButton SearchButon;
    }

    public class TopBar : Container
    {
        [FindBy(How.CssSelector, ".lang-selector")]
        public HtmlDropDown LangSelectors;

        [FindBy(How.PartialLinkText, "login")] public HtmlLink Login;

        [FindBy(How.PartialLinkText, "register")]
        public HtmlLink Register;
    }
}