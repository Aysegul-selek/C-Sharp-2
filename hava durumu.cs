using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace telefonum
{
    public partial class hava_durumu : Form
    {
        public hava_durumu()
        {
            InitializeComponent();
        }
        private const string api = "37d5ae390dad993c7ffa597bef04fdb3";
        private const string baglanti = "http://api.openweathermap.org/data/2.5/weather?q=Turkey,Elazığ&mode=xml&units=metric&APPID=" + api;


        private void hava_durumu_Load(object sender, EventArgs e)
        {
            XDocument hava = XDocument.Load(baglanti);
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            label1.Text = sicaklik.ToString()+"'";
            var durum = hava.Descendants("clouds").ElementAt(0).Attribute("name").Value;
            label3.Text = durum.ToString();
            var yer = hava.Descendants("city").ElementAt(0).Attribute("name").Value;
            label2.Text = yer.ToString();
            if (durum.Contains("clouds") == true)
            {
                bulutlu.Visible = true;

            }
            else if (durum.Contains("sun")==true)
            {
                bulutlu.Visible = false;
                güneşli.Visible = true;
            }

        }
    }
}
