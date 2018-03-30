using System;
using System.Configuration;
using System.Linq;
using Automation.Common.Helpers.Extensions;
using MoreLinq;

namespace Automation.Common.Helpers
{
    public static class ConfigurationHelper
    {
        private static string GetSettings(string settingName)
        {
            var setting = ConfigurationManager.AppSettings[settingName];
            if (setting == null)
                throw new ConfigurationErrorsException($"{settingName} setting is missing");
            return setting;
        }
        
        public static string MainUrl => GetSettings("homeUrl");
        public static Browser Browser => Browsers.GetBrowser(GetSettings("browser"));
        public static TimeSpan ElementTimeOut =>
            TimeSpan.FromSeconds(GetSettings("elementTimeout").Split(':').Last().ToInt());
    }
}