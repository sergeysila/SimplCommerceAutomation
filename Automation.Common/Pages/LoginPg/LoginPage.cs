using Automation.Common.DataModels.Users;
using Automation.Common.Helpers.Extensions;
using HtmlElements.Elements;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation.Common.Pages.LoginPg
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//form[@action='/login']")]
        private LoginForm _loginForm;

        public LoginForm LoginForm
            => _loginForm;
    }

    public class LoginForm : HtmlForm
    {
        [FindsBy(How = How.Name , Using = "Email")] 
        private HtmlInput _loginInput;

        [FindsBy(How = How.Name , Using ="Password")] 
        private HtmlInput _passwordInput;

        [FindsBy(How = How.Name ,Using = "RememberMe")] 
        private HtmlCheckBox _rememberMeCheckBox;

        [FindsBy(How = How.XPath ,Using = "button[@type='submit']")]
        private HtmlControl _loginButton;

        public void FillAndSubmit(User user)
        {
            FillForm(user);
            Submit();
        }

        public LoginForm FillForm(User user)
        {
            _loginInput.EnterText(user.Email.Value);
            _passwordInput.EnterText(user.Password);
            _passwordInput.RemoveFocus();
            return this;
        }

        public LoginForm SwitchRememberMe(bool side)
        {
            if (!_rememberMeCheckBox.Checked&&side)
            {
                _rememberMeCheckBox.Select();
            }
            return this;
        }

        public void Submit()
            => _loginButton.Submit();

        public LoginForm(IWebElement webElement) : base(webElement)
        {
        }
    }
}