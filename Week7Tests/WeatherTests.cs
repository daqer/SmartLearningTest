using System;
namespace Week7Tests
{
    public class WeatherTests
    {
        #region TempDefinition Tests
        [Theory]
        [InlineData("Cold",12)]
        [InlineData("Average", 13)]
        [InlineData("Average", 18)]
        [InlineData("Hot", 19)]
        public void CheckTempDefinitions(string expectedResult, decimal temperature)
        {
            var weatherLogic = new WeatherLogic();
            var tempDefinition = weatherLogic.GetTemperatureDefinition(temperature);
            Assert.Equal(expectedResult, tempDefinition);
        }
        #endregion
        #region FirstPartOfMessageTests
        [Fact]
        public void IsAnyTextInFirstPartOfMessage()
        {
            var weatherLogic = new WeatherLogic();
            Assert.False(string.IsNullOrWhiteSpace(weatherLogic.GetFirstPartOfMessage(20, 20)));
        }
        #endregion
        #region SecondPartOfMessageTests
        [Theory]
        [InlineData($"since It is going to a be Cold a day with 12C", "Cold", 12)]
        [InlineData($"since It is going to a be Average a day with 13C", "Average", 13)]
        [InlineData($"since It is going to a be Hot a day with 19C", "Hot", 19)]
        public void IsSecondPartOfMessageCorrect(string expectedResult,string temperatureDefinition, decimal temperature)
        {
            var weatherLogic = new WeatherLogic();
            var tempDefinition = weatherLogic.GetSecondPartOfMessage(temperatureDefinition,temperature);
            Assert.Equal(expectedResult, tempDefinition);
        }
        #endregion

        #region ThirdPartOfMessageTests
        [Theory]
        [InlineData($"also remember to enjoy the good weather since it is clear skies", "Klart Vejr")]
        [InlineData($"also remember to bring an umbrella today since it is going to rain", "Regn")]
        [InlineData($"also remember to put on a scarf and gloves when you go out since it is going to snow", "Sne")]
        [InlineData($"also you won't be seeing the sun today since it is going to be cloudy", "Skyet")]
        [InlineData($"also the weather today is going to be mysterious", "Andet")]
        public void IsThirdPartOfMessageCorrect(string expectedResult, string condition)
        {
            var weatherLogic = new WeatherLogic();
            var tempDefinition = weatherLogic.GetThirdPartOfMessage(condition);
            Assert.Equal(expectedResult, tempDefinition);
        }
        #endregion

    }
}