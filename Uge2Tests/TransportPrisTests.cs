namespace Uge2Tests
{
    public class TransportPrisTests
    {
        [Theory]
        [InlineData(0,4,9)]
        [InlineData(50, 4,11)]
        [InlineData(75,6,9)]
        [InlineData(100,10,20)]
        public void TransportPrisTest(decimal forventetPris, decimal distance, decimal v�gt )
        {
            TransportPris transportPris = new();
            decimal result = transportPris.UdregnFragtPris(distance,v�gt);
            Assert.Equal(forventetPris, result);
        }
    }
}