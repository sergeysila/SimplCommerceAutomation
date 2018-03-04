using System;
using Ipreo.AutomationFramework.UI.Services;

namespace Automation.Common.Helpers
{
    public static class Wait
    {
        private static readonly SmartWait WaitInstance = new SmartWait();

        public static void For(Func<bool> condition, string message = "")
        {
            WaitInstance.Message(message);
            WaitInstance.WaitUntil(condition);
        }

        public static void ForActionSucceeded(Action action, string message = "", int retryCount = 3)
        {
//            Policy.Handle<>()
//                .WaitAndRetry(retryCount, retryAttempt => TimeSpan.FromMilliseconds(300)).Execute(action);
        }

        public static void ForSourceChange<T>(T obj, string action)
        {
            var pageSource = Driver.WebDriver.PageSource;
            typeof(T).GetMethod(action)?.Invoke(obj, null);
            For(() => pageSource != Driver.WebDriver.PageSource);
        }

        public static void ForSourceChange(Action action)
        {
            var pageSource = Driver.WebDriver.PageSource;
            action.Invoke();
            For(() => pageSource != Driver.WebDriver.PageSource);
        }
    }
}