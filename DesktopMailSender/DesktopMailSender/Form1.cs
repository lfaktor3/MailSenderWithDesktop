using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailSender;

namespace DesktopMailSender
{
    public partial class Form1 : Form
    {
        MailClient Klijent = new MailClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            Klijent.SendEmail(Convert.ToString(inptMailTo.Text), Convert.ToString(inptSubject.Text), Convert.ToString(inptBody.Text));
        }
    }
}
