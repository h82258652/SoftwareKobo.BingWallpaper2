﻿using System.Collections.Generic;

namespace SoftwareKobo.BingWallpaper.Services
{
    internal class ServiceArea
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
                return "en-US";
            }
        }
    }
}