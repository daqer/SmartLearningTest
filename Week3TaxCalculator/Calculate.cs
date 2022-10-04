using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3TaxCalculator
{
    public class Calculate
    {
        public double TaxAtChristasPresent(double christmasGift, double secondGift)
        {
            var tax = 0.0;
            if (christmasGift + secondGift > 1200)
            {
                tax = (christmasGift > 900) ? christmasGift + secondGift : secondGift;
            }
            return tax;
        }
    }
}
