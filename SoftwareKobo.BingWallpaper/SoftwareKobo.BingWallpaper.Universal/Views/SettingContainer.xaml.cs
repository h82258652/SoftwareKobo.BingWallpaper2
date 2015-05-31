using SoftwareKobo.BingWallpaper.ViewModels;
using Windows.UI.Xaml.Controls;

// “用户控件”项模板在 http://go.microsoft.com/fwlink/?LinkId=234236 上提供

namespace SoftwareKobo.BingWallpaper.Views
{
    public sealed partial class SettingContainer : UserControl
    {
        public SettingContainer()
        {
            this.InitializeComponent();

            this.ViewModel = App.Locator.Setting;
            this.DataContext = ViewModel;
        }

        public SettingViewModel ViewModel
        {
            get;
        }
    }
}