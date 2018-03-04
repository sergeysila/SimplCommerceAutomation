using Automation.Common.Pages.LoginPages;
using Automation.Common.Pages.Sections;
using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Composite;

namespace Automation.Common.Pages
{
    [Site(Domain = "http://demo.simplcommerce.com")]
    public class SimpleCommerceSite : WebSite
    {
        [Page(Url = "/", Title = "Home Page")]
        public static HomePage HomePage;

        [Page(Url = "/login", Title = "Login Page")] 
        public static LoginPage LoginPage;
//        
//        [Page(Url = "/phones", Title = "Phones")]    
//        public static Phones PhonesPage;
//
//        [Page(Url = "/tablets", Title = "Tablets")]
//        public static Tablets TabletsPage;
//
//        [Page(Url = "/computers", Title = "Computers")]        
//        public static Computers ComputersPage;
//
//        [Page(Url = "/accessories", Title = "Accessories")]
//        public static Accessories AccessoriesPage;
        
        [FindBy(Css = "top-bar")]
        public static TopBar TopBar;
        
        [FindBy(Css = "main-header")]
        public static Header Header;

        [FindBy(Css = ".footer-content")]
        public static Footer Footer;
    }
}