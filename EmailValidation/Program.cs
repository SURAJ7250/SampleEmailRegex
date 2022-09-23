namespace EmailValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidationEmailSample emailsample = new ValidationEmailSample();
            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();
            emailsample.ValidationEmail(email);

            Console.WriteLine("Enter Email: ");
            string email1 = Console.ReadLine();
            emailsample.ValidationEmail1(email1);

            Console.WriteLine("Enter Email: ");
            string email2 = Console.ReadLine();
            emailsample.ValidationEmail2(email2);

            Console.WriteLine("Enter Email: ");
            string email3 = Console.ReadLine();
            emailsample.ValidationEmail3(email3);

            Console.WriteLine("Enter Email: ");
            string email4 = Console.ReadLine();
            emailsample.InValidationEmail(email4);
        }
    }
}