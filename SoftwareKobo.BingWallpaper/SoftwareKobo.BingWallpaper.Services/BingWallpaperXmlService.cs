﻿using SoftwareKobo.BingWallpaper.Models;
using SoftwareKobo.BingWallpaper.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace SoftwareKobo.BingWallpaper.Services
{
    [Obsolete]
    public class BingWallpaperXmlService : IBingWallpaperService
    {
        [Obsolete]
        public Task<ImageArchiveCollection> GetWallpaperInformationsAsync(int daysAgo, int count, string area)
        {
            throw new NotImplementedException();
        }
    }
}