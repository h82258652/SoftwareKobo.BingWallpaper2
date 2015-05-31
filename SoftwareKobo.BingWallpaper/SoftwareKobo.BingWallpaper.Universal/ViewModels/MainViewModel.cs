using GalaSoft.MvvmLight;
using SoftwareKobo.BingWallpaper.Services;

namespace SoftwareKobo.BingWallpaper.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IBingWallpaperService _bingWallpaperService;

        public MainViewModel(IBingWallpaperService bingWallpaperService)
        {
            _bingWallpaperService = bingWallpaperService;
        }

        public string BackgroundUrl
        {
            get;
        }
    }
}