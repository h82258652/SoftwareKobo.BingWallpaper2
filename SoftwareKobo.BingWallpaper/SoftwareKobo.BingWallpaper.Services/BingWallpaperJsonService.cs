using SoftwareKobo.BingWallpaper.Models;
using SoftwareKobo.BingWallpaper.Services.Extensions;
using SoftwareKobo.BingWallpaper.Services.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace SoftwareKobo.BingWallpaper.Services
{
    public class BingWallpaperJsonService : IBingWallpaperService
    {
        private const string LINK_TEMPLATE = @"http://www.bing.com/hpimagearchive.aspx?format=js&idx={0}&n={1}&mkt={2}";

        public async Task<ImageArchiveCollection> GetWallpaperInformationsAsync(int daysAgo, int count, string area)
        {
            string url = string.Format(LINK_TEMPLATE, daysAgo, count, area);
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.AcceptLanguage.ParseAdd(area);
                return await client.GetJsonAsync<ImageArchiveCollection>(url);
            }
        }
    }
}