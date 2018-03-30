using Automation.Common.Helpers;
using Polly;

namespace Automation.Common.Contexts
{
    public abstract class CommonContext
    {
        private static string DomainUrl { get; } = ConfigurationHelper.MainUrl;
        private DriverFactory Driver = DriverFactory.GetDriverInstance();

        protected void NavigateToPage(string path)
        {
            Policy.HandleResult<string>(url => !url.EndsWith(path))
                .Retry()
                .Execute(() =>
                {
                    var fullPath = ConfigurationHelper.MainUrl + path;
                    Driver.GoToUrl(fullPath);
                    return Driver.GetUrl();
                });
            Driver.Refresh();
        }

        public abstract void WaitForLoad();     
        protected abstract string GetPageUrl();
    }
}