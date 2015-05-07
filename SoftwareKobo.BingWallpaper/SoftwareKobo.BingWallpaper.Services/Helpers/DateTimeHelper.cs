using System;
using System.Globalization;

namespace SoftwareKobo.BingWallpaper.Services.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime Parse(string value)
        {
            return DateTime.ParseExact(value, new string[]
            {
                "yyyyMMdd",
                "yyyyMMddHHmm"
            }, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces);
        }
    }
}