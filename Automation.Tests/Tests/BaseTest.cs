using System;
using System.Collections.Generic;
using System.Linq;
using Automation.Common.Helpers;
using NUnit.Framework;

namespace Automation.Tests.Tests
{
    [TestFixture]
    public class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
        }


        [TearDown]
        public void TearDown()
        {
        }

        [TearDown]
        public static void TakeScreens()
        {
            if (ScenarioContext.Current.TestError == null) return;
            if (!Driver.IsCreated()) return;

            var ignoredBrowserErrors = new List<string>
            {
                "404 (Not Found)",
                "Cannot read property 'Announced' of undefined",
                "Cannot read property 'Live' of undefined",
                "Template parse warnings"
            };
            Driver.TakeScreenshot(ScenarioContext.Current.ScenarioInfo.Title + "_" +
                                  DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
            foreach (var log in Driver.GetLogsBrowser()
                .Where(entry => !ignoredBrowserErrors.Any(error => entry.Message.Contains(error)))
                .ToList())
                Console.WriteLine(log.ToString());
        }
    }
}