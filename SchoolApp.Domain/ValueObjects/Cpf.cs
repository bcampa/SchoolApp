using System;
using System.Text.RegularExpressions;

namespace SchoolApp.Domain.ValueObjects
{
    public class Cpf
    {
        public string Value { get; set; }

        public Cpf(string value)
        {
            Validate(value);

            Value = value;
        }

        private void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception();

            try
            {
                var regexMatches = Regex.IsMatch(value, @"^\d{11}$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
                if (!regexMatches)
                    throw new Exception();
            }
            catch (RegexMatchTimeoutException)
            {
                throw new Exception();
            }

            char[] digits = value.ToCharArray();
            byte[] convertedDigits = Array.ConvertAll(digits, x => (byte)char.GetNumericValue(x));

            var firstSum = 0;
            var secondSum = 0;

            for (byte i = 0; i <= 9; i++)
            {
                if (i < 9)
                    firstSum += convertedDigits[i] * (i + 1);

                secondSum += convertedDigits[i] * (i % 10);
            }

            var firstVerifyingDigit = (firstSum % 11) % 10;
            var secondVerifyingDigit = (secondSum % 11) % 10;

            var isValid = convertedDigits[9] == firstVerifyingDigit && convertedDigits[10] == secondVerifyingDigit;

            if (!isValid)
            {
                throw new Exception();
            }
        }
    }
}
