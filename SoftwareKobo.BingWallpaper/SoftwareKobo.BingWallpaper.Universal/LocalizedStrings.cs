using Windows.ApplicationModel.Resources;

namespace SoftwareKobo.BingWallpaper
{
	public static partial class LocalizedStrings
	{
		public static string Description
		{
			get
			{
				return ResourceLoader.GetForCurrentView().GetString("Description");
			}
		}

		public static string DisplayName
		{
			get
			{
				return ResourceLoader.GetForCurrentView().GetString("DisplayName");
			}
		}

		public static string Default
		{
			get
			{
				return ResourceLoader.GetForCurrentView("SettingView").GetString("Default");
			}
		}

		public static string Canada
		{
			get
			{
				return ResourceLoader.GetForCurrentView("SettingView").GetString("Canada");
			}
		}

		public static string China
		{
			get
			{
				return ResourceLoader.GetForCurrentView("SettingView").GetString("China");
			}
		}

		public static string Japan
		{
			get
			{
				return ResourceLoader.GetForCurrentView("SettingView").GetString("Japan");
			}
		}

		public static string NewZealand
		{
			get
			{
				return ResourceLoader.GetForCurrentView("SettingView").GetString("NewZealand");
			}
		}

		public static string PictureLibrary
		{
			get
			{
				return ResourceLoader.GetForCurrentView("SettingView").GetString("PictureLibrary");
			}
		}

		public static string ChooseEveryTime
		{
			get
			{
				return ResourceLoader.GetForCurrentView("SettingView").GetString("ChooseEveryTime");
			}
		}

		public static string SavedPictures
		{
			get
			{
				return ResourceLoader.GetForCurrentView("SettingView").GetString("SavedPictures");
			}
		}
	}
}
