namespace YoutubeSupportApp.Models
{
    public class VideoShowModel
    {
        public string Id { get; set; }
        public string VideoId { get; set; }
        public string ChannelId { get; set; }
        public string ChannelName { get; set; }
        public string PlaylistId { get; set; }
        public string PlaylistTitle { get; set; }
        public long? VideoCount { get; set; }
        public string VideoTitle { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string FolderPath { get; set; }
        public string DownloadDate { get; set; }
        public string Status { get; set; }
    }
}
