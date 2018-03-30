using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.Extensions;

namespace Automation.Common.Helpers
{
    public class DriverFactory
    {
        private readonly Browser _browserName = ConfigurationHelper.Browser;
        private static readonly ThreadLocal<DriverFactory> Instance =
            new ThreadLocal<DriverFactory>(() => new DriverFactory());

//        private static Lazy<DriverFactory> _instance =
//            new Lazy<DriverFactory>(() => new DriverFactory(), LazyThreadSafetyMode.ExecutionAndPublication);

        public IWebDriver Driver { get; set; }

        public static DriverFactory GetDriverInstance()
        {
            return Instance.Value;
        }

        public void StartBrowser()
        {
            switch (_browserName)
            {
                case Browser.Chrome:
                    var options = new ChromeOptions();
//                    options.AddUserProfilePreference("credentials_enable_service", false);  // for disabling saving passwords notification
//                    options.AddArgument("disable-infobars");    // for disabling infobar "Chrome is being controlled by automated software"
                    Driver = new ChromeDriver(options);
                    break;
                case Browser.IE:
                    Driver = new InternetExplorerDriver();
                    break;
                case Browser.Firefox:
                    Driver = new FirefoxDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"No such browser registred as:{_browserName}");
            }

            var defaultTimeOut = ConfigurationHelper.ElementTimeOut;
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = defaultTimeOut;
        }

        public void StopBrowser()
        {
            Driver.Quit();
            Driver = null;
        }

        public void GoToUrl(string path)
            => Driver.Navigate().GoToUrl(path);

        public string GetUrl()
            => Driver.Url;

        public void ExecuteScript(string script, params object[] parameters)
            => Driver.ExecuteJavaScript(script, parameters);

        public T ExecuteScript<T>(string script, params object[] parameters)
            => Driver.ExecuteJavaScript<T>(script, parameters);

        public Screenshot TakeScreenshot(string fileName)
            => Driver.TakeScreenshot();

        public IEnumerable<LogEntry> GetLogsBrowser()
            => Driver.Manage().Logs.GetLog(LogType.Browser);

        public void Refresh()
            => Driver.Navigate().Refresh();
    }
}