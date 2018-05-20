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
    public partial class radyo : Form
    {
        public radyo()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "	 http://trtcanlifm-lh.akamaihd.net/i/TRTFM_1@181846/master.m3u8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.100.100:80/best/bestfm.stream/playlist.m3u8 ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://212.224.80.85:80/dreamturk";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://kralfms.radyotvonline.com:80/dyg/kralfm64/playlist.m3u8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://95.130.169.196:80/ ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://dygwebradios.radyotvonline.com:80/dyg/kraloyunhavalari.stream/playlist.m3u8 ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://kralpopwmp.radyotvonline.com:80";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://sh.mncdn.com:8092";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://sc.powergroup.com.tr:80/PowerTurk/mpeg/128/home ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://media.netd.com.tr/S1/HLS_LIVE/slowturk/index.m3u8 ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://17733.live.streamtheworld.com/VIRGIN_RADIO.mp3";
        }

        private void radyo_Load(object sender, EventArgs e)
        {

        }
    }
}
