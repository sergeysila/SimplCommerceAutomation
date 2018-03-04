using Automation.Common.Helpers;
using Automation.Common.Pages;
using Ipreo.AutomationFramework.UI.Services;
using Polly;

namespace Automation.Common.Contexts
{
    public abstract class CommonContext
    {
        protected abstract string GetPageUrl();

        public void OpenPage()
        {
            var navigationTabs = PageService.Create<NavigationTabContainer>();
            navigationTabs.OpenTab(GetPageUrl());
        }

        protected void NavigateToPage(string path)
        {
            Policy.HandleResult<string>(url => !url.EndsWith(path))
                .Retry()
                .Execute(() =>
            {
                var fullPath = ConfigurationHelper.ServiceUrl + path;
                Driver.GoToUrl(fullPath);
                return Driver.WebDriver.Url;
            });
            Driver.Refresh();
        }

        public abstract void WaitForLoad();     
    }
}