using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class EmailSender
{
    private const string ApiKey = "3d6be783ae2c7531dc7e48040e6f392e";
    private const string ApiSecret = "4ea89411d411a20f747cc001f30881f1";
    private const string ApiBaseUrl = "https://api.mailjet.com/v3.1/send";

    public async Task SendTextMessageAsync(string toEmail, string toName, string subject, string text)
    {
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{ApiKey}:{ApiSecret}")));

            EmailMessage message = new EmailMessage
            {
                From = new EmailContact { Email = "darryl@wagoner.me", Name = "Darryl" },
                To = new EmailContact { Email = toEmail, Name = toName },
                Subject = subject,
                TextPart = text
            };

            EmailRequest request = new EmailRequest
            {
                Messages = new[] { message }
            };

            string jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(request);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(ApiBaseUrl, content);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Message sent successfully.");
            }
            else
            {
                Console.WriteLine($"Message sending failed. Status code: {response.StatusCode}");
            }
        }
    }
}

public class EmailRequest
{
    public EmailMessage[] Messages { get; set; }
}

public class EmailMessage
{
    public EmailContact From { get; set; }
    public EmailContact To { get; set; }
    public string Subject { get; set; }
    public string TextPart { get; set; }
}

public class EmailContact
{
    public string Email { get; set; }
    public string Name { get; set; }
}

class Program
{
    static async Task Main(string[] args)
    {
        EmailSender emailSender = new EmailSender();
        await emailSender.SendTextMessageAsync("darryl@wagoner.me","Darryl Wagoner","Test subject", "This is a test message from Mailjet API.");
    }
}

