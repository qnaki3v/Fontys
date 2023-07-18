using System;
using System.Net;
using System.Net.Mail;

namespace EmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the email address and password for the account you want to send email from
            string fromEmail = "rixit812@gmail.com";
            string password = "pi24pi24";

            // Set the email address you want to send the email to
            string toEmail = "yaniyanislav1234@gmail.com";

            // Set the subject and body of the email
            string subject = "Hello, World!";
            string body = "This is a test email sent from C#.";

            // Create a new instance of the SmtpClient class, which will be used to send the email
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            // Set the credentials for the email account you are sending the email from
            smtpClient.Credentials = new NetworkCredential(fromEmail, password);

            // Enable SSL for the connection
            smtpClient.EnableSsl = true;

            // Create a new instance of the MailMessage class, which will be used to hold the email contents
            MailMessage message = new MailMessage(fromEmail, toEmail, subject, body);

            // Send the email
            smtpClient.Send(message);

            Console.WriteLine("Email sent!");
        }
    }
}
