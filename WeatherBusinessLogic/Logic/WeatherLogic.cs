using System;

namespace Weather.Logic
{
    public class WeatherLogic
    {
        private const string Cold = "Cold";
        private const string Average = "Average";
        private const string Hot = "Hot";

        private const string SameTemperature = "Put on the same clothes on";
        private const string ColderTemperature = "Time to put on some more clothes on";
        private const string HotterTemperature = "Time to put the big sweater bag into storage";

        private const string ClearSkies = "also remember to enjoy the good weather since it is clear skies";
        private const string Rain = "also remember to bring an umbrella today since it is going to rain";
        private const string Snow = "also remember to put on a scarf and gloves when you go out since it is going to snow";
        private const string Cloudy = "also you won't be seeing the sun today since it is going to be cloudy";
        private const string Mysterious = "also the weather today is going to be mysterious";

        public string GetTemperatureDefinition(decimal temperature)
        {
            var result = Cold;
            if (temperature >= 13)
            {
                result = temperature >= 19 ? Hot : Average;
            }
            return result;
        }

        public string GetFirstPartOfMessage(decimal yesterdaysTemperature, decimal todaysTemperature)
        {
            var result = SameTemperature;
            if (yesterdaysTemperature != todaysTemperature)
            {
                result = yesterdaysTemperature > todaysTemperature ? ColderTemperature : HotterTemperature;
            }
            return result;
        }
        public string GetSecondPartOfMessage(string temperatureDefinition, decimal temperature)
        {
            
            return $"since It is going to a be {temperatureDefinition} a day with {temperature}C";
        }

        public string GetThirdPartOfMessage(string condition)
        {
            string result;
            switch (condition)
            {
                case "Klart Vejr":
                    result = ClearSkies;
                    break;
                case "Regn":
                    result = Rain;
                    break;
                case "Sne":
                    result = Snow;
                    break;
                case "Skyet":
                    result = Cloudy;
                    break;
                default:
                    result = Mysterious;
                    break;
            }
            return result;
        }
    }
}