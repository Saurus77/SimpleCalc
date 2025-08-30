using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc.Data.Models
{
    internal class CurrencyRate
    {
        [Key]
        public int Id { get; set; }
        public string CurrencyCode { get; set; } = string.Empty;
        public double CurrencyRates { get; set; }
        public DateTime Date { get; set; }
    }
}
