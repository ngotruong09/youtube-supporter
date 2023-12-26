using Microsoft.EntityFrameworkCore;

namespace YoutubeSupportApp.Database
{
    public class YoutubeDbContext : DbContext
    {
        public string DbPath { get; }
        public DbSet<VideoEntity> VideoEntities { get; set; }
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
            await this.VideoEntities.AddRangeAsync(videos);
            await this.SaveChangesAsync();
        }

        public async Task<List<VideoEntity>> Search(string channel, string playlist)
        {
            this.VideoEntities
                .WhereIf(!string.IsNullOrEmpty(channel), x => x.ChannelName.Contains(channel))

        }
    }
}
