using Automation.Common.DataModels;
using Automation.Common.DataModels.Builders;
using Automation.Common.DataModels.Users;
using Automation.Common.Pages;
using FluentAssertions;
using NUnit.Framework;

namespace Automation.Tests.Tests.Login
{
    [TestFixture]
    public class LoginTests
    {
        [Test]
        public void JustTest()
        {
            const int a = 1;
            const int b = 1;
            a.Should().BePositive();
            b.Should().BePositive();
            a.Should().BeGreaterOrEqualTo(b);
        }

        [Test]
        public void LoginTest()
        {
            var user = new UserBuilder()
                .WithName("Slaventiy")
                .WithEmail(new Email("char.slava@gmail.com"))
                .Build();      


            LoginPage.LoginAs(user);
            LoginPage.IsLoggedWith(user).Should().BeTrue;
        }
    }
}