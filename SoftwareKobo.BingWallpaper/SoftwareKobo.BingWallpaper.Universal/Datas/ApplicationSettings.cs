using SoftwareKobo.BingWallpaper.Helpers;
using SoftwareKobo.BingWallpaper.Services;

namespace SoftwareKobo.BingWallpaper.Datas
{
    public class ApplicationSettings : SettingsBase
    {
        private static ApplicationSettings _instance;

        public static ApplicationSettings Instance
        {
            get
            {
                _instance = _instance ?? new ApplicationSettings();
                return _instance;
            }
        }

        public string Area
        {
            get
            {
                return Get(nameof(Area), defaultValue: ServiceArea.DefaultArea, isRoaming: true);
            }
            set
            {
                AddOrUpdate(nameof(Area), value, isRoaming: true);
            }
        }

        public string SaveLocation
        {
            get
            {
                return Get(nameof(SaveLocation), defaultValue: LocalizedStrings.PictureLibrary, isRoaming: true);
            }
            set
            {
                AddOrUpdate(nameof(SaveLocation), value, isRoaming: true);
            }
        }

        public WallpaperSize WallpaperSize
        {
            get
            {
                return Get(nameof(WallpaperSize), defaultValue: WallpaperSizeHelper.GetDefaultSize());
            }
            set
            {
                AddOrUpdate(nameof(WallpaperSize), value);
            }
        }
    }
}