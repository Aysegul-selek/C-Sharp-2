using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace telefonum
{
    public partial class rehber : Form
    {
        public rehber()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=telefonrehberi1.accdb");
        OleDbCommand komut = new OleDbCommand();

        private void verilerigoruntule()
        {


            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("select*from telefonrehberi");
            OleDbDataReader oku = komut.ExecuteReader(CommandBehavior.CloseConnection);
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Ad"].ToString();
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Telefonno"].ToString());
                ekle.SubItems.Add(oku["Eposta"].ToString());
                ekle.SubItems.Add(oku["Adres"].ToString());

                listView1.Items.Add(ekle);


            }

            baglanti.Close();
        }

     

        private void rehber_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            verilerigoruntule();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into telefonrehberi(Ad,Soyad,Telefonno,Eposta,Adres)values('"+textBox1.Text.ToString()+ "','" + textBox2.Text.ToString() + "' ,'" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + richTextBox1.Text.ToString() + "')",baglanti );
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoruntule();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "(delete from telefonrehberi where Telefonno='" + textBox3.Text + "')" ;  
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoruntule();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "(update telefonrehberi set  Ad='"+textBox1.Text+ "',Soyad='" + textBox2.Text + "',Eposta='" + textBox4.Text + "',Adres='" + richTextBox1.Text + "' where Telefonno='" + textBox3.Text + "')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoruntule();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="aysegul" && textBox2.Text=="selek")
            {
                pictureBox1.ImageLocation = "C:\\Users\\pc\\Desktop\\telefonum\\b.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if(textBox1.Text == "sedef" && textBox2.Text == "şahin")
            {
                pictureBox1.ImageLocation = "C:\\Users\\pc\\Desktop\\telefonum\\woman_icon.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (textBox1.Text == "ahmet" && textBox2.Text == "demir")
            {
                pictureBox1.ImageLocation = "C:\\Users\\pc\\Desktop\\telefonum\\admin.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (textBox1.Text == "can" && textBox2.Text == "güneş")
            {
                pictureBox1.ImageLocation = "C:\\Users\\pc\\Desktop\\telefonum\\man_icon.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uygulama frm2 = new uygulama();
            frm2.Show();
            this.Visible = false;
        }
    }
}
