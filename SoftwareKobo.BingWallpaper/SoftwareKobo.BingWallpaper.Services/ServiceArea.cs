using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SoftwareKobo.BingWallpaper.Services
{
    public class ServiceArea
    {
        private static readonly IReadOnlyList<string> _supportAreas = new string[]
        {
            "de-DE",
            "en-AU",
            "en-CA",
            "en-NZ",
            "en-UK",
            "en-US",
            "ja-JP",
            "zh-CN",
        };

        public static IReadOnlyList<string> ListAllSupportAreas
        {
            get
            {
                return _supportAreas;
            }
        }

        public static string DefaultArea
        {
            get
            {
                var currentArea = CultureInfo.CurrentCulture.Name;
                if (ListAllSupportAreas.Contains(currentArea, StringComparer.OrdinalIgnoreCase))
                {
                    // 如果用户所在区域在支持区域内，则以用户所在区域作为默认值。
                    return currentArea;
                }
                return "en-US";
            }
        }
    }
}