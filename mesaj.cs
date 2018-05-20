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

namespace telefonum
{
    public partial class mesaj : Form
    {
        public mesaj()
        {
            InitializeComponent();
        }
        private MailMessage eposta = new MailMessage();
        private void mesaj_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            eposta.From = new MailAddress(textBox1.Text);
            eposta.To.Add(textBox2.Text);
            if(textBox3.Text != "")
            {
                eposta.Bcc.Add(textBox3.Text);
                eposta.Subject = textBox3.Text;
                eposta.Body = textBox6.Text;
            }

            
         


            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("aysegulselek23@gmail.com", "123456789ac.");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = eposta;
            smtp.Send(eposta);
            MessageBox.Show("gönderildi");











        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dosya;
            openFileDialog1.Title = "eklenecek dosya sec";
            openFileDialog1.ShowDialog();
            dosya = openFileDialog1.FileName;
            eposta.Attachments.Add(new Attachment(dosya));
            textBox5.Text=dosya.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uygulama frm2 = new uygulama();
            frm2.Show();
            this.Visible = false;
        }
    }


}
    