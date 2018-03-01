﻿using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace Automation.Common.Helpers
{
    public static class Driver
    {
        private static IDriver CoreDriver => DriverService.Driver;

        public static readonly IWebDriver WebDriver = DriverService.Driver.GetDriver<IWebDriver>();

        public static void GoToUrl(string path)
            => CoreDriver.Navigation.GoToUrl(path);

        public static bool IsCreated()
            => CoreDriver.DriverCreated;

        public static void Reset()
            => CoreDriver.Reset();

        public static void ExecuteScript(string script, params object[] parameters)
            => CoreDriver.ExecuteScript(script, parameters);

        public static T ExecuteScript<T>(string script, params object[] parameters)
            => (T)CoreDriver.ExecuteScript(script, parameters);

        public static void Maximize()
        {
            if (ConfigurationHelper.Browser == Browser.Firefox) return;
            CoreDriver.Maximize();
        }

        public static void TakeScreenshot(string fileName)
            => CoreDriver.TakeScreenshot(fileName);

        public static ReadOnlyCollection<LogEntry> GetLogsBrowser()
            => WebDriver.Manage().Logs.GetLog(LogType.Browser);

        public static void Refresh()
            => CoreDriver.Navigation.Refresh();
    }
}