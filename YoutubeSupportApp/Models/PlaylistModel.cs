namespace YoutubeSupportApp.Models
{
    public class PlaylistModel
    {
        public string ChannelId { get; set; }
        public string ChannelName { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public long? VideoCount { get; set; }
        public List<VideoModel> Videos { get; set; }
    }
}
