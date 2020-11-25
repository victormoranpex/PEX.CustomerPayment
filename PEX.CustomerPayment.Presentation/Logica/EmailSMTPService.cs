using HelperKit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace PEX.CustomerPayment.Presentation.Logica
{
    public class EmailSMTPService
    {
        public string NewLine { get { return "<br>"; } set { throw new Exception("No se puede asignar valor a esta propiedad IEmailService.NewLine"); } }
        private readonly string _host;
        private readonly int _port;
        private readonly string _emailFromPwd;
        private readonly SmtpClient _smtpClient;
        private readonly string _emailFrom;
        private readonly string _emailFromName;

        public EmailSMTPService()
        {


            this._emailFrom = ConfigurationManager.AppSettings["SMTP_FROM"];
            this._emailFromPwd = ConfigurationManager.AppSettings["SMTP_PASSWORD"];
            this._emailFromName = ConfigurationManager.AppSettings["SMTP_FROM_NAME"];
            this._host = ConfigurationManager.AppSettings["SMTP_HOST"];
            this._port = ConfigurationManager.AppSettings["SMTP_PORT"].ToInteger(25);

            this._smtpClient = new SmtpClient()
            {
                Host = this._host,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(this._emailFrom, this._emailFromPwd),
                Port = this._port,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Timeout = 10000,
            };
        }




        public virtual void SendMultipleEmail(List<Tuple<string, string>> emails, string subject, string body)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) =>
                {
                    return true;
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(this._emailFromName)
                };
                foreach (var email in emails)
                    mailMessage.To.Add(email.Item1);


                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = true;

                mailMessage.BodyEncoding = UTF8Encoding.UTF8;
                mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                this._smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void SendSingleEmail(string email, string name, string subject, string body)
        {
            var emails = new List<Tuple<string, string>>();
            emails.Add(new Tuple<string, string>(email, name));
            this.SendMultipleEmail(emails, subject, body);
        }


        public void SendSingleEmail(string email, string subject, string body) => SendSingleEmail(email, string.Empty, subject, body);

        public void SendMultipleEmail(List<string> emails, string subject, string body) => this.SendMultipleEmail(emails.Select(x => new Tuple<string, string>(x, string.Empty)).ToList(), subject, body);

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}