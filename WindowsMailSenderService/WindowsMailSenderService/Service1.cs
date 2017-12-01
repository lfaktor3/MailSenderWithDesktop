using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using MailSender;
using System.Threading;
using System.Configuration;

namespace WindowsMailSenderService
{
    public partial class Service1 : ServiceBase
    {
        
        public Service1()
        {
            ScheduleService();
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

        public static void ScheduleService()
        {
            MailClient Klijent = new MailClient();

            Timer Schedular = new Timer(new TimerCallback(SchedularCallback));

            DateTime scheduledTime = DateTime.MinValue;
            int intervalMinutes = 10;

            scheduledTime = DateTime.Now.AddMinutes(intervalMinutes);
            if (DateTime.Now > scheduledTime)
            {
                scheduledTime = scheduledTime.AddMinutes(intervalMinutes);
            }

            TimeSpan timeSpan = scheduledTime.Subtract(DateTime.Now);
            string schedule = string.Format("{0} day(s) {1} hour(s) {2} minute(s) {3}  seconds(s)", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            Klijent.SendEmail("luka.faktor@vsmti.hr", "MailServiceSender", Convert.ToString(schedule));

            int dueTime = Convert.ToInt32(timeSpan.TotalMilliseconds);

            Schedular.Change(dueTime, Timeout.Infinite);
        }
        private static void SchedularCallback(object e)
        {
            ScheduleService();
        }
    }
}
