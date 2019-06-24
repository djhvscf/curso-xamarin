using BrisaFresca.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace BrisaFresca.Helpers
{
    public class WeatherHelper
    {
        public async static Task<WeatherInformation> GetCurrentConditionsAsync(string cityName, string countryCode)
        {
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={cityName},{countryCode}&APPID={App.APPID}";
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(url);
            var result = JsonConvert.DeserializeObject<WeatherInformation>(response);
            return result;
        }
    }
}
