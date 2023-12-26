using System.ComponentModel.DataAnnotations;

namespace YoutubeSupportApp.Database
{
    public class VideoDownloadEntity
    {
        [Key]
        public string Id { get; set; }
        public string VideoId { get; set; }
        public string Title { get; set; }
        public string FolderPath { get; set; }
    }
}
