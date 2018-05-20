using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace telefonum
{
    public partial class alarm : Form
    {
        

        public alarm()
        {
            InitializeComponent();
        }


        private void alarm_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToShortDateString();
            textBox2.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text == DateTime.Now.ToShortDateString() && textBox2.Text == DateTime.Now.ToShortTimeString())
                timer1.Stop();
                SoundPlayer ses = new SoundPlayer();
            string yol = Application.StartupPath + "//ses//a.wav";
            ses.SoundLocation = yol;
            ses.Play();
            MessageBox.Show(textBox3.Text);
            ses.Stop();
        
            
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uygulama frm2 = new uygulama();
            frm2.Show();
            this.Visible = false;
        }
    }
}
