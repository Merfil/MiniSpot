using MiniSpot.BL.Model;
using System.Runtime.InteropServices;

namespace MiniSpot.WF
{
    public partial class FormMain : Form
    {
        private string _song;
        private bool isPlay = false;
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
        }
    }
}