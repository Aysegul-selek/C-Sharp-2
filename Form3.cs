using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefonum
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           chrome frm2 = new chrome();
            frm2.Show();
            this.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

            rehber from = new rehber();
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            mesaj from = new mesaj ();
            from.Show();
            this.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            uygulama from = new uygulama();
            from.Show();
            this.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rehber from = new rehber();
            from.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hakkımızda from = new Hakkımızda();
            from.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
