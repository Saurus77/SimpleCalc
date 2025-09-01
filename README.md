# SimpleCalc

A C# WinForms calculator application with history tracking and currency conversion using live NBP exchange rates.  

---

## Features

### Core Calculator
- Basic arithmetic operations: `+`, `-`, `*`, `/`
- Supports parentheses for operation grouping
- Handles negative numbers correctly
- Continuous calculation after pressing result

### History
- Stores calculation history in **SQLite**
- Uses **Entity Framework Core** for database access
- Allows viewing and copying past calculations

### Currency Conversion
- Integrates with **NBP API** for real exchange rates
- Stores rates in SQLite database
- Calculates the best day to convert currency within a specified date range
- Displays converted result alongside calculation

### UI
- Modern and clean **WinForms interface**
- Two-panel layout: Calculator panel and History panel
- Multi-line display: expression and result
- Keyboard support for number pad and operators

---

### Configuration:

API URLs and settings are stored in appsettings.json:
```
{
  "ApiSettings": {
    "NbpCurrencyTableA": "http://api.nbp.pl/api/exchangerates/tables/A/?format=json",
    "NbpCurrencyRatesA": "http://api.nbp.pl/api/exchangerates/rates/A/{currency}/{startDate:yyyy-MM-dd}/{endDate:yyyy-MM-dd}/?format=json"
  }
}
```

### Usage:
1. Perform calculations using buttons or keyboard.
2. View history by clicking the History menu.
3. Select a currency from the dropdown to convert the result.
4. Pick a date range to find the best conversion rate.

### Development Notes:
1. Database tables:
    - CalculationHistory (Id, Expression, Result, Date)
    - CurrencyRate (Id, CurrencyCode, CurrencyRates, Date)
      
2. EF Core handles migrations automatically.
3. CurrencyRatesService fetches and saves NBP API data.
4. Best conversion rate is selected using LINQ OrderByDescending on the stored rates.
5. Error handling includes invalid input, missing API data, and database conflicts.

### Dependencies

1. .NET 8.0
2. Newtonsoft.Json
3. Microsoft.EntityFrameworkCore
4. Microsoft.EntityFrameworkCore.Sqlite
5. Microsoft.Extensions.Configuration.Json

### Author
Mikołaj Żółciński
