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
            // Execute().Wait();
            // Console.WriteLine(GetFullName());
        }

        static string GetFullName()
        {
            var q = new System.Diagnostics.StackTrace(true).GetFrame(0).GetFileName();
            return q;
        }

        static async Task Execute()
        {
            var apiKey = "apikey";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("thiti@dosetech.co", "Not");
            var to = new EmailAddress("thiti180536@gmail.com", "Not");
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
