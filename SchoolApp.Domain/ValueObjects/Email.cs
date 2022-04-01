using System;
using System.Text.RegularExpressions;

namespace SchoolApp.Domain.ValueObjects
{
    public class Email
    {
        public string Value { get; set; }

        public Email(string value)
        {
            Validate(value);

            Value = value;
        }

        private void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("O E-mail não pode estar vazio.");

            // Validação de dominío omitida

            try
            {
                var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                var isMatch = Regex.IsMatch(value, emailPattern, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
                if (!isMatch)
                {
                    throw new Exception("O E-mail não é válido.");
                }
            }
            catch (RegexMatchTimeoutException)
            {
                throw new Exception("O E-mail não é válido.");
            }
        }
    }
}
