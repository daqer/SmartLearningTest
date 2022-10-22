using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weather.Interfaces;
using Weather.Logic;

namespace Vejrudsigten.Services
{
    public class WeatherForecast
    {
        private IWeatherService Service;
        public WeatherForecast(IWeatherService service)
        {
            Service = service;
        }
        public async Task<string> GetForecastAsync(string key)
        {
            WeatherLogic weatherLogic = new();
            var todayInfo = await Service.GetTodaysWeather(key, "Kolding");
            var yesterdayInfo = await Service.GetYesterdaysWeather(key, "Kolding");
            decimal todaysTemperature = (decimal)todayInfo.Temperature;
            decimal yesterdaysTemperature = (decimal)yesterdayInfo.Temperature;
            var message = $@"{weatherLogic.GetFirstPartOfMessage(yesterdaysTemperature, todaysTemperature)}
                             {weatherLogic.GetSecondPartOfMessage(weatherLogic.GetTemperatureDefinition(todaysTemperature),todaysTemperature)}
                             {weatherLogic.GetThirdPartOfMessage(todayInfo.Conditions)}";
            return message;
        }
    }
}
