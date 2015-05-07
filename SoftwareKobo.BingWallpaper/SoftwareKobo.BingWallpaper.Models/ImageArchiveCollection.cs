using Newtonsoft.Json;

namespace SoftwareKobo.BingWallpaper.Models
{
    [JsonObject]
    public class ImageArchiveCollection
    {
        [JsonProperty("images")]
        public ImageArchive[] Images
        {
            get;
            set;
        }

        [JsonProperty("tooltips")]
        public ToolTip ToolTip
        {
            get;
            set;
        }
    }
}