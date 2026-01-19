using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidatorCard
{
    public static class CreditCardValidator
    {
        public static bool Validate(string cardNumber, out string issuer)
        {
            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                issuer = "Unknown";
                return false;
            }

            var digits = new string(cardNumber.Where(char.IsDigit).ToArray());
            issuer = GetIssuer(digits);
            return digits.Length >= 12 && LuhnCheck(digits);
        }

        static bool LuhnCheck(string digits)
        {
            int sum = 0;
            bool doubleDigit = false;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int d = digits[i] - '0';
                if (doubleDigit)
                {
                    d *= 2;
                    if (d > 9) d -= 9;
                }
                sum += d;
                doubleDigit = !doubleDigit;
            }
            return sum % 10 == 0;
        }

        static string GetIssuer(string digits)
        {
            if (Regex.IsMatch(digits, @"^4\d{12}(\d{3})?(\d{3})?$")) return "Visa";
            if (Regex.IsMatch(digits, @"^(5[1-5]\d{14}|2(2[2-9]\d{12}|[3-6]\d{13}|7([01]\d{12}|20\d{12})))$")) return "Mastercard";
            if (Regex.IsMatch(digits, @"^3[47]\d{13}$")) return "American Express";
            if (Regex.IsMatch(digits, @"^(6011\d{12}|65\d{14}|64[4-9]\d{13}|622(12[6-9]|1[3-9]\d|[2-8]\d{2}|9([01]\d|2[0-5]))\d{10})$")) return "Discover";
            if (Regex.IsMatch(digits, @"^3(0[0-5]|[68])\d{11}$")) return "Diners Club";
            if (Regex.IsMatch(digits, @"^(352[89]\d{12}|35[3-8]\d{13})$")) return "JCB";
            return "Unknown";
        }
    }
}