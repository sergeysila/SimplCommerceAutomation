//using Automation.Common.Helpers;
//using Polly;
//
//namespace Automation.Common.Contexts
//{
//    public abstract class CommonContext
//    {
//        public abstract string GetPageUrl();
//
//        public void OpenTab()
//        {
////            var navigationTabs = PageService.Create<NavigationTabContainer>();
////            navigationTabs.OpenTab(GetPageUrl());
//        }
//
//        public void NavigateToPage(string path)
//        {
//            Policy.HandleResult<string>(url => !url.EndsWith(path)).Retry().Execute(() =>
//            {
//                var fullPath = ConfigurationHelper.ServiceUrl + path;
//                Driver.GoToUrl(fullPath);
//                return Driver.WebDriver.Url;
//            });
//            Driver.Refresh();
//        }
//
//        public abstract void WaitForLoad();
//    }
//}