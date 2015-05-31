using GalaSoft.MvvmLight;
using SoftwareKobo.BingWallpaper.Datas;
using SoftwareKobo.BingWallpaper.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftwareKobo.BingWallpaper.ViewModels
{
    public class SettingViewModel : ViewModelBase
    {
        public string[] AllSaveLocation
        {
            get;
        }
        = new string[]
        {
            LocalizedStrings.PictureLibrary,
            LocalizedStrings.ChooseEveryTime,
            LocalizedStrings.SavedPictures
        };

        public string Area
        {
            get
            {
                return ApplicationSettings.Instance.Area;
            }
            set
            {
                ApplicationSettings.Instance.Area = value;
                RaisePropertyChanged(nameof(Area));
            }
        }

        public IReadOnlyList<string> Areas
        {
            get
            {
                return ServiceArea.ListAllSupportAreas;
            }
        }

        public string SaveLocation
        {
            get
            {
                return ApplicationSettings.Instance.SaveLocation;
            }
            set
            {
                ApplicationSettings.Instance.SaveLocation = value;
                RaisePropertyChanged(nameof(SaveLocation));
            }
        }

        public WallpaperSize SelectedWallpaperSize
        {
            get
            {
                return ApplicationSettings.Instance.WallpaperSize;
            }
            set
            {
                ApplicationSettings.Instance.WallpaperSize = value;
                RaisePropertyChanged(nameof(SelectedWallpaperSize));
            }
        }

        public List<WallpaperSize> WallpaperSizes
        {
            get;
        }
        = new List<WallpaperSize>(Enum.GetValues(typeof(WallpaperSize)).Cast<WallpaperSize>());
    }
}