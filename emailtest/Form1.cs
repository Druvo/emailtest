using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace emailtest
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
 

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                string SMTPHost = host.Text;
                string SMTPUserName = username.Text;
                string SMTPPassword = password.Text;
                string address = to.Text;
                string FromEmail = username.Text;
                int SMTPPort = Convert.ToInt32(port.Text.ToString());
                MailMessage mail = new MailMessage(FromEmail, address);
                mail.Subject = subject.Text;
                mail.Body = message.Text;
                mail.IsBodyHtml = true;
                using (var client = new SmtpClient(SMTPHost, SMTPPort))
                {
                    client.EnableSsl = true;
                    //client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(SMTPUserName, SMTPPassword);
                    client.Send(mail);
                }
                MessageBox.Show("Email sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
