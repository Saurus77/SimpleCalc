using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc.Data.Models
{
    internal class CurrencyRate
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public double Rate { get; set; }
        public DateTime Date { get; set; }
    }
}
