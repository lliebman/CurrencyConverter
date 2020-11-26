using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProj
{
    interface ICurrency
    {
        string Rate { get; set; }
        string Quantity { get; set; }
    }
}
