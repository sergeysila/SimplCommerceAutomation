using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Composite;

namespace Automation.Common.Pages.Sections
{
    public class Footer : Section
    {     
        [FindBy(PartialLinkText = "help-center")] 
        public Link HelpCenter;
        
        [FindBy(PartialLinkText = "help-center/how-to-buy")] 
        public Link HowToBuy;
        
        [FindBy(PartialLinkText = "help-center/shipping")] 
        public Link Shipping;
        
        [FindBy(PartialLinkText = "help-center/how-to-return")] 
        public Link HowToReturn;
        
        [FindBy(PartialLinkText = "help-center/warranty")] 
        public Link Warranty;
        
        [FindBy(PartialLinkText = "about-us")] 
        public Link AboutUs;
        
        [FindBy(PartialLinkText = "terms-of-use")] 
        public Link TermsOfUse;
        
        [FindBy(PartialLinkText = "privacy")] 
        public Link Privacy;
    }
}







