using System.Linq;
using Microsoft.EntityFrameworkCore;

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
        public async Task<List<VideoEntity>> Search(string channel, string playlist, string video, string description)
        {
            var videos = await this.VideoEntities
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
    }
}
