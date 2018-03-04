using Automation.Common.DataModels;
using Automation.Common.DataModels.Builders;
using Automation.Common.Pages;
using Automation.Common.Pages.LoginPages;
using NUnit.Framework;

namespace Automation.Tests.Tests.Login
{
    [TestFixture]
    public class LoginTests : BaseTest
    {
        [Test]
        public void Logintest()
        {
            var user = new UserBuilder()
                .WithEmail(new Email("char.slava@gmail.com"))
                .Build();
            
            SimpleCommerceSite.LoginPage.Submit(user);
        }

//        [Test]
//        public void LoginTest()
//        {
//            var user = new UserBuilder()
//                .WithName("Slaventiy")
//                .WithEmail(new Email("char.slava@gmail.com"))
//                .Build();      
//
//
//            LoginPage.LoginAs(user);
//            LoginPage.IsLoggedWith(user).Should().BeTrue;
//        }
    }
}