using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace SendEmailCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute().Wait();
        }

        static async Task Execute()
        {
            var apiKey = "Api Key";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("thiti180536@gmail.com", "Not");
            var to = new EmailAddress("thiti@dosetech.co", "Not");
            var subject = "Sending with SendGrid";
            var plainTextContext = "and easy to do";
            var htmlContent = "<h1>Hello world</h1>";
            var msg = MailHelper.CreateSingleEmail(
                from,
                to,
                subject,
                plainTextContext,
                htmlContent
                );

            var response = await client.SendEmailAsync(msg);
            Console.WriteLine("Done");
        }
    }
}
