using System.ComponentModel.DataAnnotations;

namespace YoutubeSupportApp.Database
{
    public class VideoDownloadEntity
    {
        [Key]
        public string Id { get; set; }
        public string ChannelId { get; set; }
        public string VideoId { get; set; }
        public string VideoTitle { get; set; }
        public string FolderPath { get; set; }
        public string DownloadDate {  get; set; }
        public string Status { get; set; }
    }

    public enum StatusDownload
    {
        WAITING,
        DOWNLOADING,
        PENDING,
        DOWNLOADED,
        FAIL
    }
}
