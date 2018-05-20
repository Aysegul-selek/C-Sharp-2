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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form3 from = new Form3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre;
            sifre = textBox1.Text;

            if(sifre=="1")
            {

                MessageBox.Show("Giriş Başarılı!...");
                this.Hide();
                Form3 frm2 = new Form3();
                frm2.Show();
                this.Visible = false;
            }

            else
            { MessageBox.Show("Hatalı Giriş!..."); }
        }

    }
    }

