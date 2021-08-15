namespace SendEmailCSharp
{
    public class EmailHelper
    {
        // public async Task<HttpStatusCode> SendMailAsync(ErrorLogResponse errorLogResponse)
        // {
        //     var sendGridClient = new SendGridClient(ConnectionStrings.SendGridApiKey);

        //     var sendGridMessage = new SendGridMessage();
        //     sendGridMessage.SetFrom(new EmailAddress(ConnectionStrings.SendgridMailSender, "Kerry Log"));
        //     sendGridMessage.AddTo(ConnectionStrings.SendGridMailTo);
        //     sendGridMessage.SetTemplateId(ConnectionStrings.TemplateId);
        //     sendGridMessage.SetTemplateData(errorLogResponse);

        //     var response = await sendGridClient.SendEmailAsync(sendGridMessage);
        //     if (response.StatusCode != System.Net.HttpStatusCode.Accepted)
        //     {
        //         Console.WriteLine("Error Sending Email");
        //     }

        //     return response.StatusCode;
        // }
    }
}