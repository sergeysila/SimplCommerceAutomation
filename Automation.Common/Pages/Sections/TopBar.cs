using Automation.Common.DataModels;
using Epam.JDI.Core.Interfaces.Complex;
using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Composite;

namespace Automation.Common.Pages.Sections
{
    public class TopBar : Section
    {
        [FindBy(Css = ".lang-selector")] 
        public ISelector<Languages> LangSelectors;
        
        [FindBy(PartialLinkText = "login")] 
        public Link Login;
        
        [FindBy(PartialLinkText = "register")] 
        public Link Register;
    }
}