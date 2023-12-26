using Microsoft.EntityFrameworkCore;
using YoutubeSupportApp.Database;
using YoutubeSupportApp.Helpers;

namespace YoutubeSupportApp
{
    public partial class Form1 : Form
    {
        private WaitWndFun waitForm = new WaitWndFun();
        private YoutubeDbContext dbContext;
        private int totalRecords = 0;
        private CheckBox HeaderCheckBox = null;
        private bool IsHeaderCheckBoxClicked = false;
        public Form1()
        {
            InitializeComponent();
            dgvVideo.AutoGenerateColumns = false;
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dbContext = new YoutubeDbContext();
            this.dbContext.Database.EnsureCreated();
            this.dbContext.VideoEntities.Load();
            var total = dbContext.VideoEntities.Count();
            ResetView(total);
            this.dgvVideo.DataSource = dbContext.VideoEntities.Local.ToBindingList();
        }
        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }
        private async void btnShowVideo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChannelID.Text))
            {
                MessageBox.Show("Nhập ChannelID");
                return;
            }
            waitForm.Show(this);
            var CHANNELID = txtChannelID.Text;
            var CLIENT_SECRETS = System.Configuration.ConfigurationManager.AppSettings["CLIENT_SECRETS"];
            var playlistModels = await clsCommon.GetPlaylistModels(CLIENT_SECRETS, CHANNELID);
            foreach (var item in playlistModels)
            {
                var videos = await clsCommon.GetVideoModels(CLIENT_SECRETS, item.Id);
                if (videos.Any())
                {
                    item.Videos = videos;
                }
            }
            var combineModels = playlistModels.ToCombine();
            if (combineModels.Any())
            {
                var videos = combineModels.ToVideoEntity();
                await this.dbContext.AddVideos(videos, CHANNELID);
                dgvVideo.DataSource = videos;
                ResetView(videos.Count());
            }
            waitForm.Close();
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                waitForm.Show(this);
                var ids = GetIdSelect();
                await this.dbContext.Delete(ids);
                await Search();
                waitForm.Close();
            }
        }
        private async Task Search()
        {
            var channel = txtChannel.Text;
            var playlist = txtPlaylistTitle.Text;
            var videoTitle = txtVideoTitle.Text;
            var desc = txtDescription.Text;
            var videos = await this.dbContext.Search(channel, playlist, videoTitle, desc);
            dgvVideo.DataSource = videos;
            ResetView(videos.Count());
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await Search();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtChannel.Text = string.Empty;
            txtPlaylistTitle.Text = string.Empty;
            txtVideoTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
            dgvVideo.DataSource = null;
            ResetView(0);
        }
        private async void btnDownload_Click(object sender, EventArgs e)
        {
           
            
        }
        private void ResetView(int total)
        {
            totalRecords = total;
            groupBox3.Text = $"Total: {total} row";
        }
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();
            HeaderCheckBox.Location = new Point(67, 8);
            HeaderCheckBox.Size = new Size(16, 16);
            this.dgvVideo.Controls.Add(HeaderCheckBox);
        }
        private void HeaderCheckBoxClick(CheckBox checkBox)
        {
            IsHeaderCheckBoxClicked = true;
            foreach (DataGridViewRow row in dgvVideo.Rows)
            {
                ((DataGridViewCheckBoxCell)row.Cells["chk"]).Value = checkBox.Checked;
            }
            dgvVideo.RefreshEdit();
            IsHeaderCheckBoxClicked = false;
        }
        private List<string> GetIdSelect()
        {
            var res = new List<string>();
            for (int i = 0; i < dgvVideo.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvVideo.Rows[i].Cells["chk"].Value) == true)
                {
                    var id = dgvVideo.Rows[i].Cells["Id"].Value.ToString();
                    res.Add(id);
                }
            }
            return res;
        }
        private void dgvVideo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var value = dgvVideo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if(value != null)
                {
                    Clipboard.SetText(value.ToString());
                }
            }
        }
    }
}
