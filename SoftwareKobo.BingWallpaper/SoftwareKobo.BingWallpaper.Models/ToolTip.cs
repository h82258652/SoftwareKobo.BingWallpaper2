using Newtonsoft.Json;

namespace SoftwareKobo.BingWallpaper.Models
{
    [JsonObject]
    public class ToolTip
    {
        [JsonProperty("loading")]
        public string Loading
        {
            get;
            set;
        }

        [JsonProperty("previous")]
        public string Previous
        {
            get;
            set;
        }

        [JsonProperty("next")]
        public string Next
        {
            get;
            set;
        }

        public string walle
        {
            get;
            set;
        }

        public string walls
        {
            get;
            set;
        }
    }
}