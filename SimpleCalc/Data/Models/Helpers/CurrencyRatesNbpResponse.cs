using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc.Data.Models.Helpers
{
    internal class CurrencyRatesNbpResponse
    {
        public string table {  get; set; }
        public string currency { get; set; }
        public string code { get; set; }
        public List<CurrencyRatesNbpRate> rates { get; set; }
    }
}
