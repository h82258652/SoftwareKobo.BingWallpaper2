using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.ViewManagement;

namespace SoftwareKobo.BingWallpaper.Helpers
{
    public static class DisplayInformationHelper
    {
        public static double Height
        {
            get
            {
                return Size.Height;
            }
        }

        /// <summary>
        /// 获取当前设备的屏幕分辨率。
        /// </summary>
        public static Size Size
        {
            get
            {
#warning Not finish, need c++ and dx.
                Rect rect = ApplicationView.GetForCurrentView().VisibleBounds;
                return new Size(rect.Width, rect.Height);
            }
        }

        public static double Width
        {
            get
            {
                return Size.Width;
            }
        }
    }
}