namespace Week5CryptoTests
{
    public class CryptoCurrenciesTests
    {

        [Theory]
        [InlineData(1477.890286226647, "Bitcoin", 19119.91, "Etherioum", 1293.73, 100)]
        [InlineData(14.77890286226647, "Bitcoin", 19119.91, "Etherioum", 1293.73, 1)]
        [InlineData(0, "Bitcoin", -19119.91, "Etherioum", 1293.73, 1)]
        [InlineData(0, "Bitcoin", 19119.91, "Etherioum", -1293.73, 1)]
        [InlineData(1, "Bitcoin", 19119.91, "Bitcoin", 19119.91, 1)]
        public void TestConvertion(double iExpectedResult,string iFromCurrencyName, double iFromCurrencyPricePerUnit,string iToCurrencyName, double iToCurrencyPricePerUnit, double iAmount)
        {
            var converter = new Converter();
            converter.SetPricePerUnit(iFromCurrencyName, iFromCurrencyPricePerUnit);
            converter.SetPricePerUnit(iToCurrencyName, iToCurrencyPricePerUnit);
            Assert.Equal(iExpectedResult, converter.Convert(iFromCurrencyName, iToCurrencyName, iAmount));
        }
        [Theory]
        [InlineData(true, "Bitcoin", 19119.91, "Etherioum", 1293.73, 1)]
        [InlineData(false, "Bitcoin", 19119.91, "Etherioum", 1293.73, -1)]
        public void TestConvertException(bool iExpectedResult, string iFromCurrencyName, double iFromCurrencyPricePerUnit, string iToCurrencyName, double iToCurrencyPricePerUnit, double iAmount)
        {
            bool result;
            try
            {
                var converter = new Converter();
                converter.SetPricePerUnit(iFromCurrencyName, iFromCurrencyPricePerUnit);
                converter.SetPricePerUnit(iToCurrencyName, iToCurrencyPricePerUnit);
                var value = converter.Convert(iFromCurrencyName, iToCurrencyName, iAmount);
                result = true;
            }
            catch (ArgumentException )
            {
                result = false;
            }
           
            Assert.Equal(iExpectedResult, result);
        }

        [Theory]
        [InlineData(false, "Bitcoin", "Etherioum", 1)]
        public void TestMissingCurrencyException(bool iExpectedResult, string iFromCurrencyName,  string iToCurrencyName,  double iAmount)
        {
            bool result;
            try
            {
                var converter = new Converter();
                var value = converter.Convert(iFromCurrencyName, iToCurrencyName, iAmount);
                result = true;
            }
            catch (ArgumentException)
            {
                result = false;
            }

            Assert.Equal(iExpectedResult, result);
        }
    }
}