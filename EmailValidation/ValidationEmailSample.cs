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
        public const string VALIDEMAIL_REGEX = "^[a-z]+[.][0-9]+[@][a-zA-z]+[.][a-zA-Z]{3}$";
        public void ValidationEmail1(string email1)
        {
            Regex regex = new Regex(VALIDEMAIL_REGEX);
            bool result = regex.IsMatch(email1);
            Console.WriteLine(result);
        }
        public const string VALIDEMAIL1_REGEX = "^[a-z]+[-][0-9]+[@][a-zA-z]+[.][a-zA-Z]{3}$";
        public void ValidationEmail2(string email2)
        {
            Regex regex = new Regex(VALIDEMAIL1_REGEX);
            bool result = regex.IsMatch(email2);
            Console.WriteLine(result);
        }
        public const string VALIDEMAIL2_REGEX = "^[a-z]+[0-9]+[@][a-zA-z]+[.][a-zA-Z]{3}$";
        public void ValidationEmail3(string email3)
        {
            Regex regex = new Regex(VALIDEMAIL2_REGEX);
            bool result = regex.IsMatch(email3);
            Console.WriteLine(result);
        }
        public const string INVALIDEMAIL_REGEX = "^[a-zA-Z]$";
        public void InValidationEmail(string email4)
        {
            Regex regex = new Regex(INVALIDEMAIL_REGEX);
            bool result = regex.IsMatch(email4);
            Console.WriteLine(result);
        }
    }
}
