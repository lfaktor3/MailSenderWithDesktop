using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
/*Napisati dll koji služi za slanje mailova. Jednom kreirani dll možemo koristiti za sve buduće
vježbe u kojima će biti potrebno postali email. Projekt tipa Class Library nazvati MailSender.
Imenski prostor nazvati MailSender a klasu nazvati MailClient. Klasa sadrži sljedeće podatkovne
članove: sSmptClient, sUsername, sPassword, nPort te funkcijski član SendEmail koji ima tri 
parametra: sEmail (email račun na kojeg se šalje mail), sSubject (naslov e-maila), sBody (tijelo
poruke).*/
namespace MailSender
{
    public class MailClient
    {
        public string sSmtpClient = "smtp.office365.com";
        public string sUsername = "racunarac@vsmti.hr";
        public string sPassword = "Racunarstvo123";
        public int nPort = 587;
        public void SendEmail(string sEmail, string sSubject, string sBody)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(sSmtpClient);

            mail.From = new MailAddress(sUsername);
            mail.To.Add(new MailAddress(sEmail));
            mail.Subject = sSubject;
            mail.Body = sBody;
            SmtpServer.Port = nPort;
            SmtpServer.Credentials = new System.Net.NetworkCredential(sUsername, sPassword);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
