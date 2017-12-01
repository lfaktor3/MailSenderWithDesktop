using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender;

namespace TestMailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            MailClient Klijent = new MailClient();
            Klijent.SendEmail("luka.faktor@vsmti.hr", "Proba", "Test");
            Console.ReadKey();
        }
    }
}
