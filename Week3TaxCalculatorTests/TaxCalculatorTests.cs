using Week3TaxCalculator;
using Xunit;

namespace Week3TaxCalculatorTests
{
    public class TaxCalculatorTests
    {

        [Theory]
        [InlineData(0, 900, 0)]
        [InlineData(0, 1200, 0)]
        [InlineData(0, 900, 300)]
        [InlineData(1210, 910, 300)]
        [InlineData(500, 900, 500)]
        public void CalculatePresentTax(double expectedPrice, double christmasPresentPrice, double otherGiftPrice)
        {
            Calculate calculate = new Calculate();

            double tax = calculate.TaxAtChristasPresent(christmasPresentPrice, otherGiftPrice);

            Assert.Equal(expectedPrice, tax);
        }
    }
}
