using SoftwareKobo.BingWallpaper.Models;
using System.Threading.Tasks;

namespace SoftwareKobo.BingWallpaper.Services
{
    public interface IBingWallpaperService
    {
        Task<ImageArchiveCollection> GetWallpaperInformationsAsync(int daysAgo, int count, string area);
    }
}