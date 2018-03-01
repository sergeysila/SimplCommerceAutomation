using Automation.Common.DataModels.Users;

namespace Automation.Common.DataModels.Builders
{
    public class UserBuilder
    {
        private readonly User User;

        public UserBuilder()
        {
            User = new User
            {
                Password = "Death666"
            };
        }

        public UserBuilder WithName(string name)
        {
            User.FullName = name;
            return this;
        }

        public UserBuilder WithEmail(Email email)
        {
            User.Email = email;
            return this;
        }

        public User Build()
        {
            return User;
        }
    }
}