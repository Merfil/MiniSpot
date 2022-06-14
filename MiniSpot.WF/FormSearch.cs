using MiniSpot.BL.Controller;
using MiniSpot.BL.Model;

namespace MiniSpot.WF
{
    public partial class FormSearch : Form
    {
        Form MainForm;
        public FormSearch(Form form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            labelNameValue.Text = "";
            labelTrackValue.Text = "";
            dataGridView1.Rows.Clear();
            ApiController api = new ApiController();
            var song = new Song();
            try
            {
                song = await api.GetSongPreview(textBox1.Text);
            }
            catch (Exception)
            {
                song = null;
                labelNameValue.Text = "Песня не найдена";
                labelTrackValue.Text = "Песня не найдена";
                return;
            }

            foreach (var item in song.SpotifyTrack.Artists)
            {
                labelNameValue.Text += item.Name + ", ";
            }
            labelNameValue.Text = labelNameValue.Text.Remove(labelNameValue.Text.Length - 2, 2);
            labelTrackValue.Text = song.SpotifyTrack.Name;
            foreach (var item in song.YoutubeVideo.Audio)
            {
                dataGridView1.Rows.Add("play", item.DurationText, item.SizeText, item.Url);
            }
            for (int i = 0; i < song.YoutubeVideo.Audio.Count; i++)
            {
                var currentSong = song.YoutubeVideo.Audio[i];
                dataGridView1.Rows.Add("play", currentSong.DurationText, currentSong.SizeText, currentSong.Url);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell) != null)
            {
                Data.url = ((DataGridView)sender).Rows[e.RowIndex].Cells[3].Value.ToString();
                Data.artist = labelNameValue.Text;
                Data.track = labelTrackValue.Text;

                ((FormMain)MainForm).isPlay = false;
                ((FormMain)MainForm).PlaySong();
            }
        }
    }
}
