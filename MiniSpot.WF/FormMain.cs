using MiniSpot.BL.Model;
using System.Runtime.InteropServices;

namespace MiniSpot.WF
{
    public partial class FormMain : Form
    {
        private string _song;
        public bool isPlay = false;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        #region Drag 'n Drop
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();
        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        #endregion
        public FormMain()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            PlaySong();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBarVolume.Value = 10;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var formSearch = new FormSearch(this);
            OpenForm(formSearch);
        }

        private void OpenForm(Form form)
        {
            panelMain.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(form);
            form.Show();
        }

        public void PlaySong()
        {
            labelNameSong.Text = Data.track;
            labelArtist.Text = Data.artist;

            if (player.URL != Data.url)
                player.URL = Data.url;
            if (!isPlay)
            {
                player.controls.play();
                buttonPlay.Text = "II";
            }
            else
            {
                player.controls.pause();
                buttonPlay.Text = ">";
            }
            isPlay = !isPlay;

            var maximumPosition = Convert.ToInt32(Math.Round(player.currentMedia.duration));
            trackBarPlayback.Maximum = maximumPosition;
            trackBarVolume_Scroll(null,null);
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBarVolume.Value;
        }

        private void buttonPreviousTrack_Click(object sender, EventArgs e)
        {
            var a = player.currentMedia.duration;
            var b = player.controls.currentPosition;
            MessageBox.Show(b + " / "+a.ToString()+"   "+ Math.Round(player.currentMedia.duration));
        }

        private void trackBarPlayback_Scroll(object sender, EventArgs e)
        {

        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            Data.url = "https://r1---sn-xguxaxjvh-jx3e.googlevideo.com/videoplayback?expire=1655146651&ei=OjSnYtCVO7GN_9EPvqqSuAk&ip=3.86.36.136&id=o-AE-jeNr7tnbbhSerEJwZb6wsJ9qHLZ1TTpmgfLc1cTq-&itag=140&source=youtube&requiressl=yes&spc=4ocVCzKp4NQLoFYJt3a4bOp_u-a8Jb1jIdefdVf2JnND&vprv=1&mime=audio%2Fmp4&ns=5IkF-QIXKWhHd1Ung_yJWwIG&gir=yes&clen=3082617&dur=190.426&lmt=1577073043844879&keepalive=yes&fexp=24001373%2C24007246&c=WEB&txp=5531432&n=16O0wZP3-RtxOg&sparams=expire%2Cei%2Cip%2Cid%2Citag%2Csource%2Crequiressl%2Cspc%2Cvprv%2Cmime%2Cns%2Cgir%2Cclen%2Cdur%2Clmt&sig=AOq0QJ8wRQIhAMMquEnq5uqqLnPZlUtAp_mmJ201S3dTZk03Su4m_yiRAiA7-sqLS8HUuX2LPnmOxV0_m8zGLA9nCQvD-yS0CcqwHw%3D%3D&range=0-&cms_redirect=yes&mh=mE&mip=37.113.175.42&mm=31&mn=sn-xguxaxjvh-jx3e&ms=au&mt=1655124789&mv=m&mvi=1&pl=22&lsparams=mh,mip,mm,mn,ms,mv,mvi,pl&lsig=AG3C_xAwRAIgIgm_V0UbJuPAs3hJH5madTomyjOhKJWm9QeDsGxsnB8CIH9gLTnMCxwPKhocmcH4LL4jWb9mze2TWW06-CgOBVEt";
            Data.track = "Õóéíÿ";
            Data.artist = "Õóé";

            isPlay = false;
            PlaySong();
        }
    }
}