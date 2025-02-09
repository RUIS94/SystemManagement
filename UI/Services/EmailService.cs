using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Xml;

namespace UI.Services
{
    public class EmailService
    {
        ShareFile sf = new ShareFile();
        private string smtpAddress = "smtp.gmail.com";
        private int portNumber = 587;
        private string emailFrom;
        private string password;
        public EmailService()
        {
            LoadSensitiveInfo();
        }
        private void LoadSensitiveInfo()
        {
            string rp = sf.RP();
            string xmlFilePath = $"{rp}UI\\SensitiveInfo.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);
            emailFrom = xmlDoc.SelectSingleNode("/SensitiveInfo/EmailFrom").InnerText;
            password = xmlDoc.SelectSingleNode("/SensitiveInfo/Password").InnerText;
        }

        public void SendEmail(string emailTo, string subject, string body, string attachment)
        {
            using (MailMessage message = new MailMessage())
            {
                message.From = new MailAddress(emailFrom);
                message.To.Add(emailTo);
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;

                if (!string.IsNullOrEmpty(attachment) && File.Exists(attachment))
                {
                    Attachment attach = new Attachment(attachment);
                    message.Attachments.Add(attach);
                }
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFrom, password);
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                }
            }
        }
    }
}
