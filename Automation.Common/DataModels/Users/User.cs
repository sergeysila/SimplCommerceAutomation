namespace Automation.Common.DataModels.Users
{
    public class User
    {
        public string FullName;

        public Email Email;

        public string Password;

        public override string ToString()
            => $"Fullname: {FullName}, Email: {Email}";
    }
}