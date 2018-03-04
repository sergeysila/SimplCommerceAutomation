using System.Net.Mail;

namespace Automation.Common.DataModels
{
    public class Email
    {
        public string Value { get; }

        public Email(string value)
        {
            if (IsValid(value))
            {
                Value = value;
            }
            Value = "";
        }

        public bool IsValid(string email)
        {
            try
            {
                return new MailAddress(Value).Address.Equals(email);
            }
            catch
            {
                return false;
            }
        }
    }
}