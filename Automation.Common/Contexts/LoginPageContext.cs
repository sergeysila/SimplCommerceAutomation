using Automation.Common.DataModels;
using Automation.Common.DataModels.Users;
using Automation.Common.Helpers.Extensions;
using Automation.Common.Pages.LoginPg;
using Wait = Automation.Common.Helpers.Wait;

namespace Automation.Common.Contexts
{
    public class LoginPageContext : CommonContext
    {
        private readonly LoginPage _loginPage;
        
        public LoginPageContext()
        {
            _loginPage = new LoginPage();
        }

        protected override string GetPageUrl() 
            => SitePages.Login.GetEnumDescription();

        public override void WaitForLoad()
        {
            Wait.For(() => _loginPage.LoginForm.Element.Displayed);
        }

        public LoginPageContext Navigate()
        {
            NavigateToPage(GetPageUrl());
            return this;
        }

        public void LoginAs(User user)
        {
            _loginPage.LoginForm.FillAndSubmit(user);
        }
    }
}