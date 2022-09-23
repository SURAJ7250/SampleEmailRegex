using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailValidation
{
    public class ValidationEmailSample
    {
        public const string EMAIL_REGEX = "^[a-z]+[@][a-zA-z]+[.][a-zA-Z]{3}$";
        public void ValidationEmail(string email)
        {
            Regex regex = new Regex(EMAIL_REGEX);
            bool result = regex.IsMatch(email);
            Console.WriteLine(result);
        }
    }
}
