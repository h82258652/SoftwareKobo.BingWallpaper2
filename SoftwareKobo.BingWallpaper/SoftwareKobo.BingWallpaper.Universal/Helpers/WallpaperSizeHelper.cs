using SoftwareKobo.BingWallpaper.Services;
using System;
using System.Globalization;

namespace SoftwareKobo.BingWallpaper.Helpers
{
    public static class WallpaperSizeHelper
    {
        /// <summary>
        /// 根据当前设备的屏幕分辨率获取默认壁纸大小。
        /// </summary>
        /// <returns>默认壁纸大小。</returns>
        public static WallpaperSize GetDefaultSize()
        {
            double width = DisplayInformationHelper.Width;
            double height = DisplayInformationHelper.Height;

            WallpaperSize wallpaperSize;
            if (Enum.TryParse(string.Format(CultureInfo.InvariantCulture, "_{0}x{1}", width, height), out wallpaperSize))
            {
                return wallpaperSize;
            }
            else
            {
                // 设备分辨率未定义在枚举中。
                if (DeviceHelper.IsMobile)
                {
                    // 对于移动设备，返回 480x800 作为默认值。
                    return WallpaperSize._480x800;
                }
                else
                {
                    // 对于非移动设备，返回 800x600 作为默认值。
                    return WallpaperSize._800x600;
                }
            }
        }
    }
}