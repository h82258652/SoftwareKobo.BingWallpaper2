using Windows.Foundation.Metadata;

namespace SoftwareKobo.BingWallpaper.Helpers
{
    internal class ApiHelper
    {
        public static bool IsHardwareButtonUseable
        {
            get
            {
                return ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons");
            }
        }
    }
}