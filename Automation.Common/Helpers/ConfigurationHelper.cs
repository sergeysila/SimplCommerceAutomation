using System.Configuration;

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
        
        public static string ServiceUrl => GetSettings("uiServiceUrl");
        public static Browser Browser => Browsers.GetBrowser(GetSettings("browser"));
    }
}