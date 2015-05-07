using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SoftwareKobo.BingWallpaper.Services.Extensions
{
    public static class HttpClientExtensions
    {
        public static async Task<T> GetJsonAsync<T>(this HttpClient client, string requestUri)
        {
            string json = await client.GetStringAsync(requestUri);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static async Task<T> GetJsonAsync<T>(this HttpClient client, Uri requestUri)
        {
            string json = await client.GetStringAsync(requestUri);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}