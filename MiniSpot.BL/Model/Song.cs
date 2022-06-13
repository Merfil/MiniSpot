using Newtonsoft.Json;

namespace MiniSpot.BL.Model
{
    public class Album
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shareUrl")]
        public string ShareUrl { get; set; }

        [JsonProperty("cover")]
        public List<Cover> Cover { get; set; }
    }

    public class Artist
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shareUrl")]
        public string ShareUrl { get; set; }
    }

    public class Audio
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("durationMs")]
        public int DurationMs { get; set; }

        [JsonProperty("durationText")]
        public string DurationText { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("lastModified")]
        public object LastModified { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sizeText")]
        public string SizeText { get; set; }
    }

    public class Channel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isVerified")]
        public bool IsVerified { get; set; }

        [JsonProperty("isVerifiedArtist")]
        public bool IsVerifiedArtist { get; set; }
    }

    public class Cover
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class Song
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("youtubeVideo")]
        public YoutubeVideo YoutubeVideo { get; set; }

        [JsonProperty("spotifyTrack")]
        public SpotifyTrack SpotifyTrack { get; set; }
    }

    public class SpotifyTrack
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shareUrl")]
        public string ShareUrl { get; set; }

        [JsonProperty("durationMs")]
        public int DurationMs { get; set; }

        [JsonProperty("durationText")]
        public string DurationText { get; set; }

        [JsonProperty("artists")]
        public List<Artist> Artists { get; set; }

        [JsonProperty("album")]
        public Album Album { get; set; }
    }

    public class YoutubeVideo
    {
        [JsonProperty("searchTerm")]
        public string SearchTerm { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("channel")]
        public Channel Channel { get; set; }

        [JsonProperty("audio")]
        public List<Audio> Audio { get; set; }
    }
}
