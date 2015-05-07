using Newtonsoft.Json;

namespace SoftwareKobo.BingWallpaper.Models
{
    [JsonObject]
    public class Message
    {
        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }

        [JsonProperty("link")]
        public string Link
        {
            get;
            set;
        }

        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
    }
}