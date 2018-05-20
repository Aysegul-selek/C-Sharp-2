using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Diagnostics;

using System.Threading;

using System.Runtime.InteropServices;

namespace telefonum
{
    public partial class uygulama : Form
    {
        public uygulama()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]

        static extern IntPtr SetParent(IntPtr child, IntPtr newParent);

        [DllImport("user32.dll")]

        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]

        [return: MarshalAs(UnmanagedType.Bool)]

        private static extern bool IsWindowVisible(IntPtr hWnd);

        private const int WM_SYSCOMMAND = 274;

        private const int SC_MAXIMIZE = 61488;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            rehber frm2 = new rehber();
            frm2.Show();
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            mesaj frm2 = new mesaj();
            frm2.Show();
            this.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            camera frm2 = new camera();
            frm2.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            facebook frm2 = new facebook();
            frm2.Show();
            this.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            twitter frm2 = new twitter();
            frm2.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Instagram frm2 = new Instagram();
            frm2.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            alarm frm2 = new alarm();
            frm2.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            takvim frm2 = new takvim();
            frm2.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            radyo frm2 = new radyo();
            frm2.Show();
            this.Visible = false;
        }

        private void uygulama_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {


            string exeyolu = Application.StartupPath.ToString() + "\\nostajik radyom.exe";

            Process calistir = Process.Start(exeyolu);
            while (calistir.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(calistir.MainWindowHandle))

            {

                System.Threading.Thread.Sleep(10);

                calistir.Refresh();

            }
            calistir.WaitForInputIdle();

            SetParent(calistir.MainWindowHandle, this.Handle);

            SendMessage(calistir.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            hesap_makinesi frm2 = new hesap_makinesi();
            frm2.Show();
            this.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            chrome frm2 = new chrome();
            frm2.Show();
            this.Visible = false;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            facebook frm2 = new facebook();
            frm2.Show();
            this.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            twitter frm2 = new twitter();
            frm2.Show();
            this.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Instagram frm2 = new Instagram();
            frm2.Show();
            this.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            alarm frm2 = new alarm();
            frm2.Show();
            this.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            takvim frm2 = new takvim();
            frm2.Show();
            this.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            string exeyolu = Application.StartupPath.ToString() + "\\nostajik radyom.exe";

            Process calistir = Process.Start(exeyolu);
            while (calistir.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(calistir.MainWindowHandle))

            {

                System.Threading.Thread.Sleep(10);

                calistir.Refresh();

            }
            calistir.WaitForInputIdle();

            SetParent(calistir.MainWindowHandle, this.Handle);

            SendMessage(calistir.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            hesap_makinesi frm2 = new hesap_makinesi();
            frm2.Show();
            this.Visible = false;

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            chrome frm2 = new chrome();
            frm2.Show();
            this.Visible = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            youtube frm2 = new youtube();
            frm2.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            not_defteri frm2 = new not_defteri();
            frm2.Show();
            this.Visible = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

            hava_durumu frm2 = new hava_durumu();
            frm2.Show();
            this.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.Show();
            this.Visible = false;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            {
                play_store frm2 = new play_store();
                frm2.Show();
                this.Visible = false;
            }
        }
    }
}

