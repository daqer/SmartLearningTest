using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Interfaces
{
    public interface IWeatherService
    {

        public Task<WeatherInfo> GetTodaysWeather(string key, string location);

        public Task<WeatherInfo> GetYesterdaysWeather(string key, string location);
      
    }
}
