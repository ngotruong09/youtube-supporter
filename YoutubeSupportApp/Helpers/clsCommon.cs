using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using YoutubeExplode;
using YoutubeSupportApp.Database;
using YoutubeSupportApp.Models;

namespace YoutubeSupportApp.Helpers
{
    public static class clsCommon
    {
        public static List<CombineModel> ToCombine(this List<PlaylistModel> models)
        {
            var res = new List<CombineModel>();
            if (models != null && models.Count > 0)
            {
                foreach (var model in models)
                {
                    if (model.Videos != null)
                    {
                        foreach (var item in model.Videos)
                        {
                            var video = new CombineModel
                            {
                                ChannelId = model.ChannelId,
                                ChannelName = model.ChannelName,
                                PlaylistId = model.Id,
                                PlaylistTitle = model.Title,
                                VideoCount = model.VideoCount,
                                VideoId = item.Id,
                                VideoTitle = item.Title,
                                Url = item.Url,
                                Description = item.Description
                            };
                            res.Add(video);
                        }
                    }
                }               
            }
            return res;
        }
        public static List<VideoEntity> ToVideoEntity(this List<CombineModel> models)
        {
            var res = new List<VideoEntity>();
            if (models != null && models.Count > 0)
            {
                foreach (var item in models)
                {
                    var video = new VideoEntity
                    {
                        ChannelId = item.ChannelId,
                        ChannelName = item.ChannelName,
                        PlaylistId = item.PlaylistId,
                        PlaylistTitle = item.PlaylistTitle,
                        VideoCount = item.VideoCount,
                        VideoId = item.VideoId,
                        VideoTitle = item.VideoTitle,
                        Url = item.Url,
                        Description = item.Description
                    };
                    res.Add(video);
                }
            }
            return res;
        }
        public static async Task<bool> DownloadYouTubeVideo(string videoUrl, string outputDirectory)
        {
            var issuccess = false;
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(videoUrl);

            // Sanitize the video title to remove invalid characters from the file name
            string sanitizedTitle = string.Join("_", video.Title.Split(Path.GetInvalidFileNameChars()));

            // Get all available muxed streams
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            var muxedStreams = streamManifest.GetMuxedStreams().OrderByDescending(s => s.VideoQuality).ToList();

            if (muxedStreams.Any())
            {
                var streamInfo = muxedStreams.First();
                using var httpClient = new HttpClient();
                var stream = await httpClient.GetStreamAsync(streamInfo.Url);

                string outputFilePath = Path.Combine(outputDirectory, $"{sanitizedTitle}.{streamInfo.Container}");
                using var outputStream = File.Create(outputFilePath);
                await stream.CopyToAsync(outputStream);
                issuccess = true;
            }
            return issuccess;
        }
        public static async Task<List<VideoModel>> GetVideoModels(string CLIENT_SECRETS, string playlistId)
        {
            var videoModels = new List<VideoModel>();
            List<PlaylistItem> playlistItems = new List<PlaylistItem>();
            await GetVideoByPlaylistId(playlistItems, string.Empty, CLIENT_SECRETS, playlistId);
            if (playlistItems.Any())
            {
                videoModels = playlistItems.Select(x => new VideoModel
                {
                    Id = x.Snippet.ResourceId.VideoId,
                    Title = x.Snippet.Title,
                    Description = x.Snippet.Description,
                    Url = @$"https://www.youtube.com/watch?v={x.Snippet.ResourceId.VideoId}"
                }).ToList();
            }
            return videoModels;
        }
        public static async Task GetVideoByPlaylistId(List<PlaylistItem> playlistItems, string pageToken, string CLIENT_SECRETS, string playlistId)
        {
            YouTubeService yt = new YouTubeService(new BaseClientService.Initializer() { ApiKey = CLIENT_SECRETS });
            var request = yt.PlaylistItems.List("snippet");
            request.PlaylistId = playlistId;
            request.PageToken = pageToken;
            request.MaxResults = 50;

            var response = await request.ExecuteAsync();
            if (response.Items.Count > 0)
            {
                playlistItems.AddRange(response.Items);
            }
            if (!string.IsNullOrEmpty(response.NextPageToken))
            {
                await GetVideoByPlaylistId(playlistItems, response.NextPageToken, CLIENT_SECRETS, playlistId);
            }
        }
        public static async Task<List<PlaylistModel>> GetPlaylistModels(string CLIENT_SECRETS, string CHANNELID)
        {
            var playlistModels = new List<PlaylistModel>();
            var playlists = new List<Playlist>();
            await GetPlaylists(playlists, string.Empty, CLIENT_SECRETS, CHANNELID);
            if (playlists.Any())
            {
                playlistModels = playlists.Select(x => new PlaylistModel
                {
                    Id = x.Id,
                    VideoCount = x.ContentDetails.ItemCount,
                    Title = x.Snippet.Title,
                    ChannelName = x.Snippet.ChannelTitle,
                    ChannelId = x.Snippet.ChannelId,
                }).ToList();
            }
            return playlistModels;
        }
        public static async Task GetPlaylists(List<Google.Apis.YouTube.v3.Data.Playlist> playlists, string pageToken, string CLIENT_SECRETS, string CHANNELID)
        {
            YouTubeService yt = new YouTubeService(new BaseClientService.Initializer() { ApiKey = CLIENT_SECRETS });
            var request = yt.Playlists.List("snippet,contentDetails");
            request.ChannelId = CHANNELID;
            request.MaxResults = 50;
            request.PageToken = pageToken;
            var response = await request.ExecuteAsync();
            if (response.Items.Count > 0)
            {
                playlists.AddRange(response.Items);
            }
            if (!string.IsNullOrEmpty(response.NextPageToken))
            {
                await GetPlaylists(playlists, response.NextPageToken, CLIENT_SECRETS, CHANNELID);
            }
        }
    }
}
