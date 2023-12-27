namespace YoutubeSupportApp.Models
{
    public class SelectModel
    {
        public string Id { get; set; }
        public string ChannelId { get; set; }
        public string Url { get; set; }
        public string VideoId { get; set; }
        public string VideoTitle { get; set; }
        public DateTime DownloadDate { get; set; }
    }
}
