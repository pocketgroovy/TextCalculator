using System;
using System.Net.Mail;

namespace eMailSender
{
    public class FullConfiguredEmail : ISend
    {
        private MailMessage mail;
        private SmtpClient client;
        public FullConfiguredEmail()
        {

            client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = true;
            client.Host = "smtp.gmail.com";

        }
        public void Send(string to, string messge)
        {
            MailAddress fromAdd = new MailAddress("info@pocketgroovy.com");
            MailAddress toAdd = new MailAddress(to);
            mail = new MailMessage(fromAdd, toAdd);
            mail.Subject = "Error on Calculation";
            mail.Body = messge;
            try
            {
                Console.WriteLine("sending mail");
                client.Send(mail);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception thrown at Email Sender: " + ex.ToString());
            }
        }
    }
}
