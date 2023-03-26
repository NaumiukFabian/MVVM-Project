using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows;
using System.Xml.Linq;

namespace ReportB2C.ModelsLocal
{
    public class SmptClientAccess : ISmptClientAccess
    {
        public SmtpClient SmtpClient { get; set; }
        public MailAddress From { get; set; }
        public MailAddress To { get; set; }
        public MailMessage MailMessage { get; set; }
        public MailAddress Copy { get; set; }
        public Attachment AttachmentEpu { get; set; }
        public SmptClientAccess()
        {
            SmtpClient = new SmtpClient("");
        }

        public void SetClientRaport(string messageBody, string subject, string data)
        {
            System.Net.NetworkCredential networkCredential;

            SmtpClient.UseDefaultCredentials = false;
            SmtpClient.Port = 587;
            networkCredential = new System.Net.NetworkCredential("", "");
            SmtpClient.Credentials = networkCredential;
            System.Net.Mime.ContentType contentType = new System.Net.Mime.ContentType();
            contentType.MediaType = System.Net.Mime.MediaTypeNames.Application.Octet;

            From = new MailAddress("", "Raporty");
            To = new MailAddress("", "");
            Copy = new MailAddress("");
            MailMessage = new System.Net.Mail.MailMessage(From, To);
            MailMessage.CC.Add(Copy);

            MailMessage.Subject = subject + data;
            MailMessage.SubjectEncoding = System.Text.Encoding.UTF8;

            MailMessage.Body = messageBody;
            MailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            MailMessage.IsBodyHtml = true;

            SmtpClient.Send(MailMessage);
        }

        public void SetClientEpu(string messageBody, string subject, string copy, string path, string to)
        {
            System.Net.NetworkCredential networkCredential;

            SmtpClient.UseDefaultCredentials = false;
            SmtpClient.Port = 587;
            networkCredential = new System.Net.NetworkCredential("", "");
            SmtpClient.Credentials = networkCredential;
            System.Net.Mime.ContentType contentType = new System.Net.Mime.ContentType();
            contentType.MediaType = System.Net.Mime.MediaTypeNames.Application.Octet;

            From = new MailAddress("", "");
            To = new MailAddress(to);

            MailMessage = new System.Net.Mail.MailMessage(From, To);
            MailMessage.Bcc.Add(From);

            if (!String.IsNullOrEmpty(copy))
            {
                Copy = new MailAddress(copy);
                MailMessage.CC.Add(Copy);
            }

            if (!String.IsNullOrEmpty(path))
            {
                MailMessage.Attachments.Add(AttachmentEpu);
            }

            MailMessage.Subject = subject;
            MailMessage.SubjectEncoding = System.Text.Encoding.UTF8;

            MailMessage.Body = messageBody;
            MailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            MailMessage.IsBodyHtml = true;

            SmtpClient.Send(MailMessage);
        }

        public void Attachment(string file, string pathName)
        {
            System.Net.Mime.ContentType contentType = new System.Net.Mime.ContentType();
            contentType.MediaType = System.Net.Mime.MediaTypeNames.Application.Octet;

            contentType.Name = pathName;

            AttachmentEpu = new Attachment(file, contentType);
        }
    }
}
