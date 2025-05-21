using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class EmailHelper
    {
        public static bool SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("studocument559@gmail.com", "tsdo ebli tbob iyej"),
                    EnableSsl = true
                };

                MailMessage mail = new MailMessage("studocument559@gmail.com", toEmail, subject, body);
                client.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
