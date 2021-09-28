using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CinemaStep.Service
{
    public class SendMailService
    {
        public static void SendMail1(string mail)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("keephesabi01@gmail.com", "parolubilmirem1."),
                EnableSsl = true,
            };

            smtpClient.Send("keephesabi01@gmail.com", "rafaelxelilzade01@gmail.com", "Cinema Management System", "Hello");

        }
    }
}
