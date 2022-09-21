namespace Uge2TransportPris
{
    public class TransportPris
    {
        private readonly decimal MaxDistance = 5;
        private readonly decimal MaxVægt = 10;
        private readonly decimal LowPrice = 0;
        private readonly decimal MediumPrice = 50;
        private readonly decimal HighPrice = 75;
        private readonly decimal DefaultPrice = 100;

        public decimal UdregnFragtPris(decimal distance, decimal vægt)
        {
            decimal result = LowPrice;
            if (distance < MaxDistance && vægt > MaxVægt)
            {
                result = MediumPrice;
            }
            if (distance > MaxDistance && vægt < MaxVægt)
            {
                result = HighPrice;
            }
            if (distance > MaxDistance && vægt > MaxVægt)
            {
                result = DefaultPrice;
            }
            return result;
        }
        public decimal EksempelTagetFraJesper(decimal distance, decimal vægt)
        {
            decimal result;
            if (distance < MaxDistance)
            {
                result = (vægt < MaxVægt) ? LowPrice : MediumPrice;
            }
            else
            {
                result = (vægt < MaxVægt) ? HighPrice : DefaultPrice;
            }
            return result;
        }
    }
}
