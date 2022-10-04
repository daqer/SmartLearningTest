namespace Uge2TransportPris
{
    public class TransportPris
    {
        private readonly decimal MaxDistance = 5;
        private readonly decimal MaxWeight = 10;
        private readonly decimal LowPrice = 0;
        private readonly decimal MediumPrice = 50;
        private readonly decimal HighPrice = 75;
        private readonly decimal DefaultPrice = 100;

        public decimal CalculateShippingCost(decimal distance, decimal weight)
        {
            decimal result = LowPrice;
            if (distance < MaxDistance && weight > MaxWeight)
            {
                result = MediumPrice;
            }
            if (distance > MaxDistance && weight < MaxWeight)
            {
                result = HighPrice;
            }
            if (distance > MaxDistance && weight > MaxWeight)
            {
                result = DefaultPrice;
            }
            return result;
        }
        public decimal ExampleFromJesper(decimal distance, decimal vægt)
        {
            decimal result;
            if (distance < MaxDistance)
            {
                result = (vægt < MaxWeight) ? LowPrice : MediumPrice;
            }
            else
            {
                result = (vægt < MaxWeight) ? HighPrice : DefaultPrice;
            }
            return result;
        }
    }
}
