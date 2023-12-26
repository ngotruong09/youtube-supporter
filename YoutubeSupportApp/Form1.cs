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

        public Form1()
        {
            InitializeComponent();
            dgvVideo.AutoGenerateColumns = false;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.dbContext = new YoutubeDbContext();
            this.dbContext.Database.EnsureCreated();
            this.dbContext.VideoEntities.Load();
            totalRecords = dbContext.VideoEntities.Count();
            groupBox3.Text = $"Total: {totalRecords} row";
            this.dgvVideo.DataSource = dbContext.VideoEntities.Local.ToBindingList();
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
                totalRecords = videos.Count();
                groupBox3.Text = $"Total: {totalRecords} row";
            }
            waitForm.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }
    }
}
