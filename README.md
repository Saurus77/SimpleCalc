# SimpleCalc

**SimpleCalc** is a Windows Forms desktop application built with **.NET 8** that functions as a scientific-style calculator with advanced features such as:  

- Basic arithmetic operations with operator precedence
- Parentheses handling
- Continuous calculations
- History tracking
- Currency conversion using NBP (National Bank of Poland) API

The application uses **SQLite** for storing calculation history and fetched currency rates.

---

## Table of Contents

- [Features](#features)  
- [Technologies](#technologies)  
- [Installation](#installation)  
- [Usage](#usage)  
- [Project Structure](#project-structure)  
- [Database](#database)  
- [API Integration](#api-integration)  
- [Contributing](#contributing)  
- [License](#license)  

---

## Features

- **Arithmetic Calculations**
  - Addition, Subtraction, Multiplication, Division
  - Supports parentheses for proper order of operations
  - Handles negative numbers and decimal points

- **Continuous Calculation**
  - Automatically updates result as new numbers/operators are added

- **Calculation History**
  - Stores all calculations in a local SQLite database
  - Displays history in a `DataGridView`

- **Currency Conversion**
  - Fetches current exchange rates from NBP API
  - Converts between currencies for a selected date range
  - Displays the best rate for conversions

---

## Technologies

- **.NET 8**  
- **Windows Forms** (WinForms)  
- **SQLite** (via Entity Framework Core)  
- **Entity Framework Core** (for ORM)  
- **Newtonsoft.Json** (for API JSON parsing)  
- **Microsoft.Extensions.Configuration** (for appsettings.json)

---

## Installation


1. Clone the repository:

    ```bash
    git clone https://github.com/yourusername/SimpleCalc.git
    ```

2. Open the solution in Visual Studio 2022 (or later).
3. Restore NuGet packages:
    - Microsoft.EntityFrameworkCore
    - Microsoft.EntityFrameworkCore.Sqlite
    - Microsoft.EntityFrameworkCore.Tools
    - Newtonsoft.Json
    - Microsoft.Extensions.Configuration    
4. Build the solution.
5. Run the application.

> The SQLite database simpleCalc.db will be automatically created in the project directory when the app is first run.
---
## Usage

1. Calculator
    - Enter expressions using the number buttons and operators panel.
    - Use parentheses ( ) to group operations.
    - Press = to calculate the result.
    - Clear using the C button or remove the last character with <-.
2. Continuous Calculation
    - The calculator displays an updated result dynamically as operators and numbers are entered.
3. History
    - Open the history view via Menu -> History.
    - View previous calculations in a table with expression, result, and timestamp.
4. Currency Conversion
    - Open conversion panel via Menu -> Conversion.
    - Select a currency code from the dropdown.
    - Select a date using the calendar.
    - Click Convert to fetch rates from NBP API and display conversion.
  
---
## Project Structure
```
SimpleCalc/
│
├─ Data/
│  ├─ Models/
│  │  ├─ CalculationHistory.cs
│  │  ├─ CurrencyRate.cs
│  │  └─ Helpers/
│  │     ├─ CurrencyRatesNbpResponse.cs
│  │     ├─ CurrencyRatesNbpRate.cs
│  │     ├─ CurrencyRatesNbpAllCurrenciesResponse.cs
│  │     └─ CurrencyRatesNbpAllCurrenciesRates.cs
│  ├─ Services/
│  │  ├─ CalculationHistoryService.cs
│  │  └─ CurrencyRatesService.cs
│  ├─ CalculationLogic.cs
│  ├─ ExpressionHolder.cs
│  ├─ SimpleCalcDbContext.cs
│  └─ Tokenizer.cs
│
├─ Form1.cs
├─ Form1.Designer.cs
├─ Program.cs
├─ appsettings.json
├─ SimpleCalc.csproj
└─ README.md
```
---
## Database
The app uses SQLite with Entity Framework Core.

### Tables:

1. CalculationHistory
    - Id (PK)
    - Expression (string)
    - Result (double)
    - Date (DateTime)
2. CurrencyRate
    - Id (PK)
    - Code (string, currency code)
    - Rate (double)
    - Date (DateTime)

> The database file is ```simpleCalc.db``` and is created automatically on first run.

---

## API Integration

- NBP API (National Bank of Poland) for currency rates:
    - Fetches all currencies: ```https://api.nbp.pl/api/exchangerates/tables/a/?format=json```
    - Fetches historical rates: ```http://api.nbp.pl/api/exchangerates/rates/A/{currency}/{startDate}/{endDate}/?format=json```
- Responses are parsed using Newtonsoft.Json into CurrencyRatesNbpResponse and helper classes.

---

## Contributing

1. Fork the repository.
2. Create a new branch: ```git checkout -b feature/YourFeature```
3. Make your changes and commit: ```git commit -m 'Add new feature'```
4. Push to the branch: ```git push origin feature/YourFeature```
5. Open a pull request.

---

## License

This project is licensed under the MIT License.

## Author

Mikołaj Żółciński
