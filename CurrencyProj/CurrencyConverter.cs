using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProj
{
    class CurrencyConverter
    {
        public CurrencyConverter() { }
        public void convertFromRate(ICurrency currency, string strMasterQuantity)
        {
            decimal decCurrencyRate = StringToDecimal(currency.Rate);
            decimal decMasterQuant = StringToDecimal(strMasterQuantity);
            decimal newCurrencyQuant = decMasterQuant * decCurrencyRate;
            currency.Quantity = newCurrencyQuant.ToString();
        }

        public void covertFromQuantity(ICurrency masterCurrency, List<ICurrency> allCurrencies)
        {
            decimal decMasterQuant = StringToDecimal(masterCurrency.Quantity);
            decimal decMasterRate = StringToDecimal(masterCurrency.Rate);
            foreach (ICurrency currency in allCurrencies)
            {
                if (!currency.Equals(masterCurrency.GetType()))
                {
                    decimal currencyRate = StringToDecimal(currency.Rate);
                    decimal newCurrencyQuant = decMasterQuant / decMasterRate * currencyRate;
                    currency.Quantity = newCurrencyQuant.ToString();
                }
            }
        }

        private decimal StringToDecimal(String strInput)
        {
            decimal dmlOutput = 0.0m;
            Decimal.TryParse(strInput, out dmlOutput);
            return dmlOutput;
        }
    }
}
