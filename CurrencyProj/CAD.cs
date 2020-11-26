using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProj
{
    class CAD : ICurrency
    {
        public string Rate { get; set; }
        public string Quantity { get; set; }

        public CAD(string rate, string quantity)
        {
            Rate = rate;
            Quantity = quantity;
        }
    }
}
