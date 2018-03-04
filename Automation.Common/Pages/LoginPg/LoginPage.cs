using Automation.Common.DataModels.Users;
using Automation.Common.Helpers.Extensions;
using Ipreo.AutomationFramework.UI.Components;
using Ipreo.AutomationFramework.UI.Components.Search;

namespace Automation.Common.Pages.LoginPg
{
    public class LoginPage : BasePage
    {
        [FindBy(How.Xpath, "//form[@action='/login']")]
        private LoginForm _loginForm;

        public LoginForm LoginForm
            => _loginForm;
    }

    public class LoginForm : Container
    {
        [FindBy(How.Name , "Email")] 
        private HtmlTextField _loginInput;

        [FindBy(How.Name , "Password")] 
        private HtmlTextField _passwordInput;

        [FindBy(How.Name , "RememberMe")] 
        private HtmlCheckBox _rememberMeCheckBox;

        [FindBy(How.Xpath , "button[@type='submit']")]
        private HtmlButton _loginButton;

        public void FillAndSubmit(User user)
        {
            FillForm(user);
            Submit();
        }

        public LoginForm FillForm(User user)
        {
            _loginInput.SetText(user.Email.Value);
            _passwordInput.SetText(user.Password);
            _passwordInput.RemoveFocus();
            return this;
        }

        public LoginForm SwitchRememberMe(bool side)
        {
            _rememberMeCheckBox.SetValue(side);
            return this;
        }

        public void Submit()
            => _loginButton.Click();
    }
}