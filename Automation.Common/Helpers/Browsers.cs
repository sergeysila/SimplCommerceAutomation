﻿using System;

namespace Automation.Common.Helpers
{
    public static class Browsers
    {
        public static Browser GetBrowser(string setting)
        {
            switch (setting.ToLower())
            {
                case "chrome": return Browser.Chrome;
                case "ie": return Browser.IE;
                case "firefox": return Browser.Firefox;
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }

    public enum Browser
    {
        Chrome,
        IE,
        Firefox
    }
}