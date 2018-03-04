using Automation.Common.Pages;
using Epam.JDI.Core.Settings;
using JDI_Web.Selenium.DriverFactory;
using JDI_Web.Selenium.Elements.Composite;
using JDI_Web.Settings;
using NUnit.Framework;

namespace Automation.Tests.Tests
{
    [TestFixture]
    public class BaseTest
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            WebSettings.InitNUnitDefault();
            var logger = JDISettings.Logger;
            logger.Info("Init test run...");
            WinProcUtils.KillAllRunWebDrivers();
            
            WebSite.Init(typeof(SimpleCommerceSite));
            SimpleCommerceSite.HomePage.Open();
            logger.Info("Run test...");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            WinProcUtils.KillAllRunWebDrivers();
        }

        [SetUp]
        public void SetUp()
        {
        }


//        [TearDown]
//        public void TearDown()
//        {
//            Driver.Reset();
//        }

//        [TearDown]
//        public static void TakeScreens()
//        {
//            if (!TestExecutionContext.CurrentContext.StopOnError) return;
//            if (!Driver.IsCreated()) return;
//
//            var ignoredBrowserErrors = new List<string>
//            {
//                "404 (Not Found)",
//                "Cannot read property 'Announced' of undefined",
//                "Cannot read property 'Live' of undefined",
//                "Template parse warnings"
//            };
//            Driver.TakeScreenshot(TestExecutionContext.CurrentContext.CurrentTest.Name + "_" +
//                                  DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
//            foreach (var log in Driver.GetLogsBrowser()
//                .Where(entry => !ignoredBrowserErrors.Any(error => entry.Message.Contains(error)))
//                .ToList())
//                Console.WriteLine(log.ToString());
//        }
    }
}