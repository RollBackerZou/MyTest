using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace Mail
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var senderer = From.Text;
            var receiver = To.Text;
            var content = Content.Text;

            MailAddress from = new MailAddress(senderer);
            MailAddress to = new MailAddress(receiver);
            MailMessage message = new MailMessage(from,to);
            message.Subject = "Test Mail Service!!";
            message.Body = content;
            message.BodyEncoding = Encoding.UTF8;

            SmtpClient client = new SmtpClient("163.com");
            client.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
            client.Port = 25;
            client.Send(message);
        }
    }
}
