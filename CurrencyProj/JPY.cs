using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProj
{
    class JPY : ICurrency
    {
        public string Rate { get; set; }
        public string Quantity { get; set; }

        public JPY(string rate, string quantity)
        {
            Rate = rate;
            Quantity = quantity;
        }
    }
}
