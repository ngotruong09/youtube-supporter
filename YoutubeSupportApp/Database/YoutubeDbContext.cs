using Microsoft.EntityFrameworkCore;
using YoutubeSupportApp.Models;

namespace YoutubeSupportApp.Database
{
    public class YoutubeDbContext : DbContext
    {
        public string DbPath { get; }
        public DbSet<VideoEntity> VideoEntities { get; set; }
        public DbSet<VideoDownloadEntity> VideoDownloadEntities { get; set; }
        public YoutubeDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "youtube.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
        public async Task AddVideos(List<VideoEntity> videos, string channelId)
        {
            var videoOlds = this.VideoEntities.Where(x => x.ChannelId == channelId).ToList();
            if (videoOlds.Count > 0)
            {
                this.VideoEntities.RemoveRange(videoOlds);
                await this.SaveChangesAsync();
            }
            videos.ForEach(x => x.Id = Guid.NewGuid().ToString("N"));
            await this.VideoEntities.AddRangeAsync(videos);
            await this.SaveChangesAsync();
        }
        public async Task<List<VideoShowModel>> Search(string channel, string playlist, string video, string description)
        {
            var query = from v in this.VideoEntities
                        join d in this.VideoDownloadEntities on v.VideoId equals d.VideoId into g1
                        from subd in g1.DefaultIfEmpty()
                        select new VideoShowModel
                        {
                            Id = v.Id,
                            VideoId = v.VideoId,
                            ChannelId = v.ChannelId,
                            ChannelName = v.ChannelName,
                            PlaylistId = v.PlaylistId,
                            PlaylistTitle = v.PlaylistTitle,
                            VideoCount = v.VideoCount,
                            VideoTitle = v.VideoTitle,
                            Description = v.Description,
                            Url = v.Url,
                            FolderPath = subd.FolderPath,
                            DownloadDate = subd.DownloadDate,
                            Status = subd.Status
                        };
            var videos = await query
                 .WhereIf(!string.IsNullOrEmpty(channel), x => x.ChannelName.Contains(channel))
                 .WhereIf(!string.IsNullOrEmpty(playlist), x => x.PlaylistTitle.Contains(playlist))
                 .WhereIf(!string.IsNullOrEmpty(video), x => x.VideoTitle.Contains(video))
                 .WhereIf(!string.IsNullOrEmpty(description), x => x.Description.Contains(description))
                 .ToListAsync();
            return videos;
        }
        public async Task Delete(List<string> ids)
        {
            var videoOlds = this.VideoEntities.Where(x => ids.Contains(x.Id)).ToList();
            if (videoOlds.Count > 0)
            {
                this.VideoEntities.RemoveRange(videoOlds);
                await this.SaveChangesAsync();
            }
        }
        public async Task AddDownload(List<VideoDownloadEntity> videos)
        {
            var videoIDs = videos.Select(x => x.VideoId).ToList();
            var videoOlds = this.VideoDownloadEntities.Where(x => videoIDs.Contains(x.VideoId)).ToList();
            if (videoOlds.Count > 0)
            {
                this.VideoDownloadEntities.RemoveRange(videoOlds);
                await this.SaveChangesAsync();
            }
            videos.ForEach(x => x.Id = Guid.NewGuid().ToString("N"));
            await this.VideoDownloadEntities.AddRangeAsync(videos);
            await this.SaveChangesAsync();
        }
    }
}
