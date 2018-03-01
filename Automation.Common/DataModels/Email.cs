using System.Net.Mail;

namespace Automation.Common.DataModels
{
    public class Email
    {
        private readonly string _value;

        public Email(string value)
        {
            if (IsValid(value))
            {
                _value = value;
            }
            _value = "";
        }

        public bool IsValid(string email)
        {
            try
            {
                return new MailAddress(_value).Address.Equals(email);
            }
            catch
            {
                return false;
            }
        }
    }
}