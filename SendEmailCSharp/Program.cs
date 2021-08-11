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
            var apiKey = "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";
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
