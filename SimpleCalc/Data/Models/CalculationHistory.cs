using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc.Data.Models
{
    internal class CalculationHistory
    {
        [Key] //Marks Id as primary key in sql
        public int Id { get; set; }
        public string Expression { get; set; } = string.Empty;
        public double Result { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
