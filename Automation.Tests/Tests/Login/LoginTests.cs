using Automation.Common.Contexts;
using Automation.Common.DataModels;
using Automation.Common.DataModels.Builders;
using NUnit.Framework;

namespace Automation.Tests.Tests.Login
{
    [TestFixture]
    public class LoginTests : BaseTest
    {
        LoginPageContext loginContext = new LoginPageContext();

        [Test]
        public void Logintest()
        {
            var user = new UserBuilder()
                .WithEmail(new Email("char.slava@gmail.com"))
                .Build();
            
           loginContext.LoginAs(user);
        }
    }
}