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
    public partial class not_defteri : Form
    {
        public not_defteri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();
            ac.Title = "Dosya ac";
            ac.Filter = "Text diyalogları |*.txt";
            if(ac.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(ac.FileName,RichTextBoxStreamType.PlainText);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Title = "Dosya Kaydet";
            kaydet.Filter = "text dosyalrı |*.txt";
            if(kaydet.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.SaveFile(kaydet.FileName,RichTextBoxStreamType.PlainText);
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
