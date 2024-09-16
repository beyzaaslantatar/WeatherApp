using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public static class ApiService
    {
        public static async Task<Root> GetWeather(double latitude, double longtitude)
        {
            var httpClient = new HttpClient();
           var response = await httpClient.GetStringAsync(string.Format( "https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&units=metric&appid=7ebce6f99b789af6f04db92ebe3d4a8c" , latitude ,longtitude));
           return JsonConvert.DeserializeObject<Root>(response);
        }

        public static async Task<Root> GetWeatherByCity(string city)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&appid=7ebce6f99b789af6f04db92ebe3d4a8c", city));
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
