using System;
using System.Collections.Generic;
using System.Linq;
using Automation.Common.Helpers;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Automation.Tests.Tests
{
    [TestFixture]
    public class BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
        }

        [SetUp]
        public void SetUp()
        {
            Driver.GoToUrl(ConfigurationHelper.ServiceUrl);
            Driver.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Reset();
        }

        [TearDown]
        public static void TakeScreens()
        {
            if (!TestExecutionContext.CurrentContext.StopOnError) return;
            if (!Driver.IsCreated()) return;

            var ignoredBrowserErrors = new List<string>
            {
                "404 (Not Found)",
                "Cannot read property 'Announced' of undefined",
                "Cannot read property 'Live' of undefined",
                "Template parse warnings"
            };
            Driver.TakeScreenshot(TestExecutionContext.CurrentContext.CurrentTest.Name + "_" +
                                  DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
            foreach (var log in Driver.GetLogsBrowser()
                .Where(entry => !ignoredBrowserErrors.Any(error => entry.Message.Contains(error)))
                .ToList())
                Console.WriteLine(log.ToString());
        }
    }
}