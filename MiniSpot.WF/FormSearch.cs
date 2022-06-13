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
            dataGridView1.Rows.Clear();
            ApiController api = new ApiController();
            var song = await api.GetSongPreview(textBox1.Text);

            foreach (var item in song.SpotifyTrack.Artists)
            {
                labelNameValue.Text += item.Name + ", ";
            }
            labelTrackValue.Text = song.SpotifyTrack.Name;
            foreach (var item in song.YoutubeVideo.Audio)
            {
                dataGridView1.Rows.Add("play", item.DurationText, item.SizeText, item.Url);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell) != null)
            {
                Data.url = ((DataGridView)sender).Rows[e.RowIndex].Cells[3].Value.ToString();
                ((FormMain)MainForm).PlaySong();
            }
        }
    }
}
