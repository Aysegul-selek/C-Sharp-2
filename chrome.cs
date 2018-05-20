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
    public partial class chrome : Form
    {
        public chrome()
        {
            InitializeComponent();
        }

        private void chrome_Load(object sender, EventArgs e)
        {
           
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(maskedTextBox1.Text);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void quickPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();

        }

        private void forwadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uygulama frm2 = new uygulama();
            frm2.Show();
            this.Visible = false;
        }
    }
}
