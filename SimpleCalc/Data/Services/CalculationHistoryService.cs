using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalc.Data.Models;

namespace SimpleCalc.Data.Services
{
    internal static class CalculationHistoryService
    {
        public static void AddToHistory(string expression, double result)
        {
            using (var db = new SimpleCalcDbContext())
            {
                var entry = new CalculationHistory
                {
                    Expression = expression,
                    Result = result
                };
                db.CalculationHistory.Add(entry);
                db.SaveChanges();
            }
        }

        public static void LoadHistory(DataGridView dataGridView)
        {
            using var db = new SimpleCalcDbContext();

            dataGridView.Rows.Clear();

            foreach (var record in db.CalculationHistory.OrderByDescending(h => h.Date))
            {
                dataGridView.Rows.Add(record.Expression, record.Result.ToString(), record.Date);
            }
        }
    }
}
