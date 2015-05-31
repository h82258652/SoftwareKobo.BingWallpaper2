using Windows.System.Profile;

namespace SoftwareKobo.BingWallpaper.Helpers
{
    public class DeviceHelper
    {
        public static string DeviceType
        {
            get
            {
                return AnalyticsInfo.VersionInfo.DeviceFamily;
            }
        }

        public static bool IsDesktop
        {
            get
            {
                return DeviceType == "Windows.Desktop";
            }
        }

        public static bool IsMobile
        {
            get
            {
                return DeviceType == "Windows.Mobile";
            }
        }
    }
}