using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;

namespace MailProgramm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
            

            try
            {
                MailMessage mail = new MailMessage(from.Text, to.Text, subject.Text, body.Text);
                SmtpClient client = new SmtpClient(smtp.Text);
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(username.Text, password.Text);
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("Mail sent!");
            }

            catch
            {
                MessageBox.Show("Error: Mail not sent.");
            }


            
        }

        private void hifeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
