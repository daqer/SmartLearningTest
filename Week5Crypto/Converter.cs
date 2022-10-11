using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrency
{
    public class Converter
    {
        public Dictionary<string, double> CryptoCurrencies { get; set; } = new Dictionary<string, double>();
        /// <summary>
        /// Angiver prisen for en enhed af en kryptovaluta. Prisen angives i dollars.
        /// Hvis der tidligere er angivet en værdi for samme kryptovaluta, 
        /// bliver den gamle værdi overskrevet af den nye værdi
        /// </summary>
        /// <param name="currencyName">Navnet på den kryptovaluta der angives</param>
        /// <param name="price">Prisen på en enhed af valutaen målt i dollars. Prisen kan ikke være negativ</param>
        public void SetPricePerUnit(String currencyName, double price)
        {
            var exists = CryptoCurrencies.ContainsKey(currencyName);
            price = (price < 0) ? 0 : price;
            if (exists)
            {
                CryptoCurrencies[currencyName] = price;
            }
            else
            {
                CryptoCurrencies.Add(currencyName, price);
            }
        }

        /// <summary>
        /// Konverterer fra en kryptovaluta til en anden. 
        /// Hvis en af de angivne valutaer ikke findes, kaster funktionen en ArgumentException
        /// 
        /// </summary>
        /// <param name="fromCurrencyName">Navnet på den valuta, der konverterers fra</param>
        /// <param name="toCurrencyName">Navnet på den valuta, der konverteres til</param>
        /// <param name="amount">Beløbet angivet i valutaen angivet i fromCurrencyName</param>
        /// <returns>Værdien af beløbet i toCurrencyName</returns>
        public double Convert(String fromCurrencyName, String toCurrencyName, double amount)
        {
            if (!CryptoCurrencies.TryGetValue(fromCurrencyName, out double fromPricePerUnit) || !CryptoCurrencies.TryGetValue(toCurrencyName, out double toPricePerUnit) || amount <= 0)
            {
                throw new ArgumentException();
            }
            double rate = (fromPricePerUnit == 0 || toPricePerUnit == 0) ? 0 : fromPricePerUnit / toPricePerUnit;
            return (rate == 0) ? 0 : rate * amount;
        }
    }
}
