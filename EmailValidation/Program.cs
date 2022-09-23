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
        }
    }
}