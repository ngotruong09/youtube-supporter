using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using YoutubeSupportApp.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public async Task<int> AddVideos(List<VideoEntity> videos, string channelId)
        {
            int count = 0;
            if (videos.Any())
            {
                await this.Database.EnsureCreatedAsync();
                var videoOlds = this.VideoEntities.Where(x => x.ChannelId == channelId).ToList();
                if (videoOlds.Count > 0)
                {
                    this.VideoEntities.RemoveRange(videoOlds);
                    await this.SaveChangesAsync();
                }
                videos.ForEach(x => x.Id = Guid.NewGuid().ToString("N"));
                await this.VideoEntities.AddRangeAsync(videos);
                await this.SaveChangesAsync();
                count = videos.Count;
            }
            return count;
        }
        public async Task<List<VideoShowModel>> Search(string channel, string playlist, string video, string description, string status)
        {
            await this.Database.EnsureCreatedAsync();
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
                 .WhereIf(!string.IsNullOrEmpty(status), x => x.Status == (status == "Chưa download" ? null : status))
                 .OrderByDescending(p => string.IsNullOrEmpty(p.Status) == false)
                 .ThenBy(p => p.Status)
                 .ToListAsync();
            return videos;
        }
        public async Task Delete(List<string> ids)
        {
            await this.Database.EnsureCreatedAsync();
            var videoOlds = this.VideoEntities.Where(x => ids.Contains(x.Id)).ToList();
            if (videoOlds.Count > 0)
            {
                this.VideoEntities.RemoveRange(videoOlds);
                await this.SaveChangesAsync();
            }
        }
        public async Task AddDownload(List<VideoDownloadEntity> videos)
        {
            await this.Database.EnsureCreatedAsync();
            var videoIDs = videos.Select(x => x.VideoId.Trim()).ToList();
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
        public async Task UpdateStatusDownload(string videoId, string status)
        {
            await this.Database.EnsureCreatedAsync();
            var downloads = this.VideoDownloadEntities.Where(x => x.VideoId == videoId).ToList();
            if (downloads.Any())
            {
                var items = downloads.First();
                items.Status = status;
                await this.SaveChangesAsync();
            }
        }
        public async Task<List<string>> GetPlaylistTitles()
        {
            await this.Database.EnsureCreatedAsync();
            var playlistTitles = await this.VideoEntities.GroupBy(g => new { g.PlaylistTitle })
                     .Select(g => g.First().PlaylistTitle)
                     .ToListAsync();
            return playlistTitles;
        }
        public async Task<List<VideoShowModel>> GetDownloading()
        {
            await this.Database.EnsureCreatedAsync();
            var query = from v in this.VideoEntities
                        join d in this.VideoDownloadEntities on v.VideoId equals d.VideoId into g1
                        from subd in g1.DefaultIfEmpty()
                        where subd.Status == "Đang chờ" || subd.Status == "Đang download"
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
                        }
                        ;
            var list = await query.ToListAsync();
            return list;
        }
    }
}
