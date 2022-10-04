namespace Uge2Tests
{
    public class TransportPrisTests
    {
        [Theory]
        [InlineData(0,4,9)]
        [InlineData(50, 4,11)]
        [InlineData(75,6,9)]
        [InlineData(100,10,20)]
        public void TransportPrisTest(decimal expectedPrice, decimal distance, decimal weight )
        {
            TransportPris transportPrice = new();
            decimal result = transportPrice.CalculateShippingCost(distance,weight);
            Assert.Equal(expectedPrice, result);
        }
        [Theory]
        [InlineData(0, 4, 9)]
        [InlineData(50, 4, 11)]
        [InlineData(75, 6, 9)]
        [InlineData(100, 10, 20)]
        public void TransportPrisTestJesper(decimal expectedPrice, decimal distance, decimal weight)
        {
            TransportPris TransportPrice = new();
            decimal result = TransportPrice.ExampleFromJesper(distance, weight);
            Assert.Equal(expectedPrice, result);
        }
    }
}