﻿using System.Collections.Concurrent;
using YoutubeSupportApp.Database;
using YoutubeSupportApp.Helpers;
using YoutubeSupportApp.Models;

namespace YoutubeSupportApp
{
    public partial class Form1 : Form
    {
        private WaitWndFun waitForm = new WaitWndFun();
        private YoutubeDbContext dbContext;
        private int totalRecords = 0;
        private CheckBox HeaderCheckBox = null;
        private bool IsHeaderCheckBoxClicked = false;
        private string __playlistTitle = string.Empty;
        private string __status = string.Empty;
        public Form1()
        {
            InitializeComponent();
            dgvVideo.AutoGenerateColumns = false;
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dbContext = new YoutubeDbContext();
            //this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();
            await SetCbx();
            await Search();
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
                videos.ForEach(x => x.VideoId?.Trim());
                videos = videos.GroupBy(g => new { g.VideoId })
                         .Select(g => g.First())
                         .ToList();
                await this.dbContext.AddVideos(videos, CHANNELID);
                await SetCbx();
                await Search();
            }
            waitForm.Close();
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                waitForm.Show(this);
                var item = GetSelect();
                var ids = item.Select(x => x.Id).ToList();
                await this.dbContext.Delete(ids);
                await SetCbx();
                await Search();
                waitForm.Close();
            }
        }

        private async Task SetCbx()
        {
            cbxPlaylist.DataSource = await this.dbContext.GetPlaylistTitles();
            __playlistTitle = string.Empty;
            cbxPlaylist.SelectedIndex = -1;
        }

        private async Task Search()
        {
            var channel = txtChannel.Text;
            var playlist = __playlistTitle;
            var videoTitle = txtVideoTitle.Text;
            var desc = txtDescription.Text;
            var status = __status;
            var videos = await this.dbContext.Search(channel, playlist, videoTitle, desc, status);
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
            __playlistTitle = string.Empty;
            cbxPlaylist.SelectedIndex = -1;
            txtVideoTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
            dgvVideo.DataSource = null;
            HeaderCheckBox.Checked = false;
            IsHeaderCheckBoxClicked = false;
            ResetView(0);
        }
        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolderPath.Text))
            {
                MessageBox.Show("Nhập đường dẫn lưu video");
                return;
            }
            if (Directory.Exists(txtFolderPath.Text) == false)
            {
                MessageBox.Show("Đường dẫn lưu video không tồn tại");
                return;
            }
            var items = GetSelect();
            if (items.Any())
            {
                // save download ban dau
                var videoDownloads = items.Select(x => new VideoDownloadEntity
                {
                    ChannelId = x.ChannelId,
                    VideoTitle = x.VideoTitle,
                    VideoId = x.VideoId,
                    DownloadDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                    FolderPath = txtFolderPath.Text,
                    Status = nameof(StatusDownload.WAITING)
                }).ToList();
                await this.dbContext.AddDownload(videoDownloads);
                // run background worker
                progressBar1.Value = 0;
                progressBar1.Maximum = items.Count;
                bworkerDownload.RunWorkerAsync();
            }
        }
        private void ResetView(int total)
        {
            totalRecords = total;
            groupBox3.Text = $"Total: {total} row";
        }
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();
            HeaderCheckBox.Location = new Point(69, 5);
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
        private List<SelectModel> GetSelect()
        {
            var res = new List<SelectModel>();
            for (int i = 0; i < dgvVideo.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvVideo.Rows[i].Cells["chk"].Value) == true)
                {
                    var id = dgvVideo.Rows[i].Cells["Id"].Value?.ToString();
                    var videoTitle = dgvVideo.Rows[i].Cells["VideoTitle"].Value?.ToString();
                    var url = dgvVideo.Rows[i].Cells["Url"].Value?.ToString();
                    var videoId = dgvVideo.Rows[i].Cells["VideoId"].Value?.ToString();
                    var channelId = dgvVideo.Rows[i].Cells["ChannelId"].Value?.ToString();
                    var item = new SelectModel
                    {
                        Id = id,
                        VideoTitle = videoTitle,
                        Url = url,
                        VideoId = videoId,
                        ChannelId = channelId
                    };
                    res.Add(item);
                }
            }
            return res;
        }
        private void dgvVideo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var value = dgvVideo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value != null)
                {
                    Clipboard.SetText(value.ToString());
                }
            }
        }

        private void bworkerDownload_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!timerRefreshForm.Enabled)
            {
                timerRefreshForm.Start();
            }
            var items = GetSelect();
            var tasks = new List<Task>();
            var queue = new ConcurrentQueue<SelectModel>(items);
            bool isExist = false;
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (queue.Count > 0)
                    {
                        // DoWork
                        tasks.Add(
                            Task.Run(async () =>
                            {
                                if (queue.TryDequeue(out var item))
                                {
                                    try
                                    {
                                        using (var db = new YoutubeDbContext())
                                        {
                                            await db.UpdateStatusDownload(item.VideoId, nameof(StatusDownload.DOWNLOADING));
                                        }

                                        await clsCommon.DownloadYouTubeVideo(item.Url, txtFolderPath.Text);

                                        using (var db = new YoutubeDbContext())
                                        {
                                            await db.UpdateStatusDownload(item.VideoId, nameof(StatusDownload.DONE));
                                        }

                                        bworkerDownload.ReportProgress(0);
                                    }
                                    catch (Exception ex)
                                    {
                                        //Console.WriteLine(ex.ToString());
                                    }
                                }
                            }));
                    }
                    else
                    {
                        isExist = true;
                        break;
                    }
                }
                if (isExist == false)
                {
                    Task.WaitAll(tasks.ToArray());
                }
                else
                {
                    break;
                }
            }
            if (tasks.Count > 0)
            {
                Task.WaitAll(tasks.ToArray());
            }
            bworkerDownload.ReportProgress(0);
        }

        private void bworkerDownload_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Value += 1;
            }
            catch
            {
            }
        }

        private async void bworkerDownload_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (timerRefreshForm.Enabled)
            {
                timerRefreshForm.Stop();
            }
            await Search();
            progressBar1.Value = 0;
        }

        private async void timerRefreshForm_Tick(object sender, EventArgs e)
        {
            await Search();
        }

        private void cbxPlaylist_SelectedValueChanged(object sender, EventArgs e)
        {
            __playlistTitle = cbxPlaylist.SelectedItem as string;
        }

        private void cbxStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            __status = cbxStatus.SelectedItem as string;
        }
    }
}
