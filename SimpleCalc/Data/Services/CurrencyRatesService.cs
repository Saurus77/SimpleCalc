using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SimpleCalc.Data.Models;
using SimpleCalc.Data.Models.Helpers;
using Microsoft.Extensions.Configuration;
using System.Runtime.InteropServices;

namespace SimpleCalc.Data.Services
{
    internal class CurrencyRatesService
    {
        private readonly SimpleCalcDbContext _dbContext;
        private readonly HttpClient _httpClient;

        public CurrencyRatesService(SimpleCalcDbContext dbContext)
        {
            _dbContext = dbContext;
            _httpClient = new HttpClient();
        }

        public async Task FetchAndSaveCurrencyRatesAsync(
            string currency, DateTime startDate, DateTime endDate)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            string urlTemplate = config["ApiSettings:NbpCurrencyRatesA"];

            string url = urlTemplate
                .Replace("{currency}", currency)
                .Replace("{startDate:yyyy-MM-dd}", startDate.ToString("yyyy-MM-dd"))
                .Replace("{endDate:yyyy-MM-dd}", endDate.ToString("yyyy-MM-dd"));

            using var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return;
            }

            string json = await _httpClient.GetStringAsync(url);

     

            var data = JsonConvert.DeserializeObject<CurrencyRatesNbpResponse>(json);

            if(data?.rates == null)
            {
                return;
            }

            foreach (var rate in data.rates)
            {
                var entity = new CurrencyRate
                {
                    Code = data.code,
                    Date = DateTime.Parse(rate.effectiveDate),
                    Rate = rate.mid
                };

                if(!_dbContext.CurrencyRate.Any(r => r.Code == entity.Code && r.Date == entity.Date))
                {
                    _dbContext.CurrencyRate.Add(entity);
                }
            }

            await _dbContext.SaveChangesAsync();
        }

        public CurrencyRate GetBestRate(string currency, DateTime startDate, DateTime endDate)
        {
            var bestRate = _dbContext.CurrencyRate
                .Where(r => r.Code == currency && r.Date >= startDate && r.Date <= endDate)
                .OrderByDescending(r => r.Rate)
                .FirstOrDefault();
            if(bestRate == null)
            {
                return new CurrencyRate
                {
                    Code = currency,
                    Rate = 0,
                    Date = DateTime.Today
                };
            }
            return bestRate;
        }

        public static async Task LoadCurrencyCodesToComboBoxAsync(ComboBox comboBox)
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

            string url = config["ApiSettings:NbpCurrencyTableA"];

            using HttpClient client = new HttpClient();

            string json = await client.GetStringAsync(url);

            var tables = JsonConvert.DeserializeObject<CurrencyRatesNbpAllCurrenciesResponse[]>(json);

            if(tables != null && tables.Length > 0)
            {
                comboBox.Items.Clear();

                foreach (var rate in tables[0].rates)
                {
                    comboBox.Items.Add(rate.code);
                }
            }
        }
    }
}
