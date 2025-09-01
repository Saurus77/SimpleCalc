using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimpleCalc.Data.Models.Helpers
{
    internal class CurrencyRatesNbpAllCurrenciesResponse
    {
        public string table { get; set; }
        public string no { get; set; }
        public string effectiveDate { get; set; }
        public CurrencyRatesNbpAllCurrenciesRates[] rates { get; set; }
    }
}
