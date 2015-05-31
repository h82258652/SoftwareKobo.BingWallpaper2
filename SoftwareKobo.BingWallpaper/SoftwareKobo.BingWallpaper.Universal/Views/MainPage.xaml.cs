using SoftwareKobo.BingWallpaper.Helpers;
using SoftwareKobo.BingWallpaper.ViewModels;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SoftwareKobo.BingWallpaper.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.ViewModel = App.Locator.Main;
            this.DataContext = ViewModel;
        }

        public MainViewModel ViewModel
        {
            get;
        }

        private void ShowAbout()
        {
            if (DeviceHelper.IsDesktop)
            {
                DesktopAboutFlyout aboutFlyout = new DesktopAboutFlyout();
                aboutFlyout.ShowIndependent();
            }
            else
            {
                Frame.Navigate(typeof(AboutPage));
            }
        }

        private void ShowSetting()
        {
            if (DeviceHelper.IsDesktop)
            {
                DesktopSettingFlyout settingFlyout = new DesktopSettingFlyout();
                settingFlyout.ShowIndependent();
            }
            else
            {
                Frame.Navigate(typeof(SettingPage));
            }
        }
    }
}