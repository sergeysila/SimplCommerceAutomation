using System.Drawing.Printing;
using Automation.Common.DataModels.Users;
using Epam.JDI.Core.Interfaces.Common;
using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Composite;

namespace Automation.Common.Pages.LoginPages
{
    public class LoginPage : WebPage
    {
        [FindBy(XPath = "//form[@action='/login']")]
        private Form<User> LoginForm;
        //public Form<LoginFormContainer> LoginForm;

        public void Submit(User user)
        {
            LoginForm.Submit(user);
        }
    }

    public partial class LoginFormContainer
    {
        [FindBy(Name = "Email")]
        public Input LoginInput;

        [FindBy(Name = "Password")]
        public Input PasswordInput;
        
        [FindBy(Name = "RememberMe")]
        public ICheckBox RememberMeCheckBox;

        [FindBy(XPath = "button[@type='submit']")]
        public IButton LoginButton;
    }
}