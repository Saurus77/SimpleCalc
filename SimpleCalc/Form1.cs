using System;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Input;
using Microsoft.VisualBasic.Devices;
using SimpleCalc.Data;
using SimpleCalc.Data.Services;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        private readonly SimpleCalcDbContext _dbContext;
        private readonly CurrencyRatesService _currencyRatesService;

        public Form1()
        {
            InitializeComponent();

            _dbContext = new SimpleCalcDbContext();
            _currencyRatesService = new CurrencyRatesService(_dbContext);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            SetupHistoryGrid();
            CalculationHistoryService.LoadHistory(HistoryDataGrid);
            await CurrencyRatesService.LoadCurrencyCodesToComboBoxAsync(CurrencyCodesComboBox);

            string defaultCurrency = "EUR";
   
            CurrencyCodesComboBox.SelectedItem = defaultCurrency;
  

            await _currencyRatesService.FetchAndSaveCurrencyRatesAsync(defaultCurrency, DateTime.Today, DateTime.Today);

            string defaultStartEndDate = DateTime.Today.ToString("yyyy-MM-dd");
            startDateLabel.Text = defaultStartEndDate;
            endDateLabel.Text = defaultStartEndDate;
            var bestRate = _currencyRatesService.GetBestRate(defaultCurrency, DateTime.Parse(startDateLabel.Text), DateTime.Parse(endDateLabel.Text));
            CurrencyRateLabel.Text = bestRate.Rate.ToString();
 



        }


        private void MainCalculatorPanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void CopySelectedCells()
        {
            if (HistoryDataGrid.SelectedCells.Count > 0)
            {
                // Group cells by row index to preserve row structure
                var rows = HistoryDataGrid.SelectedCells
                    .Cast<DataGridViewCell>()
                    .GroupBy(c => c.RowIndex)
                    .OrderBy(g => g.Key);

                var sb = new StringBuilder();

                foreach (var row in rows)
                {
                    // Order cells by column index
                    var cells = row.OrderBy(c => c.ColumnIndex);
                    sb.AppendLine(string.Join("\t", cells.Select(c => c.Value?.ToString() ?? "")));
                }

                Clipboard.SetText(sb.ToString());
            }
        }

        private void SetupHistoryGrid()
        {
            HistoryDataGrid.Columns.Clear();

            HistoryDataGrid.Columns.Add("Expression", "Expression");
            HistoryDataGrid.Columns.Add("Result", "Result");
            HistoryDataGrid.Columns.Add("Date", "Date");

            HistoryDataGrid.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            HistoryDataGrid.RowHeadersDefaultCellStyle.ForeColor = Color.White;

            HistoryDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            HistoryDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            HistoryDataGrid.EnableHeadersVisualStyles = false;

            HistoryDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HistoryDataGridCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Color.Black;
            e.CellStyle.ForeColor = Color.White;
        }


        // Logic for showing/hiding history panel
        private void Menu_Strip_History_Click(object sender, EventArgs e)
        {
            if (!HistoryDataGrid.Visible)
            {
                CalculationHistoryService.LoadHistory(HistoryDataGrid);
                HistoryDataGrid.Visible = true;
                MainCalculatorPanel.Visible = false;
                MainCurrencyConversionPanel.Visible = false;
            }
            else
            {
                HistoryDataGrid.Visible = false;
                MainCalculatorPanel.Visible = true;
            }
        }

        // Logic to bind focus to main window on start
        protected override void OnShown(EventArgs e)
        {
            ActiveControl = null;
            PreventFocusChange(this);
            base.OnShown(e);
        }

        // Logic to prevent focus changes on mouse clicks
        // and disable tab switch on all elements
        private void PreventFocusChange(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (!(control is ComboBox))
                {
                    control.MouseUp += (s, e) => ActiveControl = null;
                    control.TabStop = false;

                    if (control.HasChildren)
                    {
                        PreventFocusChange(control);
                    }
                }
            }
        }


        // A method to send button/key values to expression holder variable
        // and show contents in display label
        private void UniversalKey_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                Console.WriteLine(ExpressionHolder.Expression);
                if (ExpressionHolder.Operators.Contains(button.Text))
                {
                    ExpressionHolder.CheckFirstChar(ExpressionHolder.Expression, button.Text);

                    if (WasResultPressed)
                    {
                        ExpressionHolder.Expression = ResultDisplay_Label.Text;
                        WasResultPressed = false;
                    }
                    Console.WriteLine("not a number");


                    ExpressionHolder.Expression =
                        ExpressionHolder.CheckLastChar(ExpressionHolder.Expression, button.Text);
                    Console.WriteLine(ExpressionHolder.Expression);
                    ExpressionDisplay_Label.Text = ExpressionHolder.Expression;

                }
                else
                {
                    Console.WriteLine("a number");
                    if (WasResultPressed)
                    {
                        ExpressionHolder.Expression = string.Empty;
                        WasResultPressed = false;
                    }
                    ExpressionHolder.Expression += button.Text;
                    Console.WriteLine(ExpressionHolder.Expression);
                    ExpressionDisplay_Label.Text = ExpressionHolder.Expression;
                }


            }
        }

        // Method for keyboard binding
        private void UniversalKeyDown_Click(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                // Number keys 0-9
                case Keys.D1:
                case Keys.NumPad1:
                    NumberKey_1.PerformClick();
                    break;

                case Keys.D2:
                case Keys.NumPad2:
                    NumberKey_2.PerformClick();
                    break;

                case Keys.D3:
                case Keys.NumPad3:
                    NumberKey_3.PerformClick();
                    break;

                case Keys.D4:
                case Keys.NumPad4:
                    NumberKey_4.PerformClick();
                    break;

                case Keys.D5:
                case Keys.NumPad5:
                    NumberKey_5.PerformClick();
                    break;

                case Keys.D6:
                case Keys.NumPad6:
                    NumberKey_6.PerformClick();
                    break;

                case Keys.D7:
                case Keys.NumPad7:
                    NumberKey_7.PerformClick();
                    break;

                case Keys.D8 when !e.Shift:
                case Keys.NumPad8:
                    NumberKey_8.PerformClick();
                    break;

                case Keys.D9 when !e.Shift:
                case Keys.NumPad9:
                    NumberKey_9.PerformClick();
                    break;

                case Keys.D0 when !e.Shift:
                case Keys.NumPad0:
                    NumberKey_0.PerformClick();
                    break;

                case Keys.Decimal:
                case Keys.Oemcomma:
                    NumberKey_Comma.PerformClick();
                    break;

                // Operators

                case Keys.Add:
                case Keys.Oemplus when e.Shift:
                    Add_Key.PerformClick();
                    break;

                case Keys.Subtract:
                case Keys.OemMinus:
                    Subtract_Key.PerformClick();
                    break;

                case Keys.Multiply:
                case Keys.D8 when e.Shift:
                    Multiply_Key.PerformClick();
                    break;

                case Keys.Divide:
                case Keys.OemQuestion when !e.Shift:
                    Divide_Key.PerformClick();
                    break;

                // Parentheses
                case Keys.D9 when e.Shift:
                    Left_Parentheses_Btn.PerformClick();
                    break;

                case Keys.D0 when e.Shift:
                    Right_Parentheses_Btn.PerformClick();
                    break;

                // Result
                case Keys.Enter:
                case Keys.Oemplus when !e.Shift:
                    Result_Key.PerformClick();
                    break;

                case Keys.Back:
                    BackSpace_Btn.PerformClick();
                    break;

            }
            // Grid copy
            if (e.Control && e.KeyCode == Keys.C)
            {
                CopySelectedCells();
                e.Handled = true;
            }

            // Paste expression

            if (e.Control && e.KeyCode == Keys.V)
            {
                if (Clipboard.ContainsText())
                {
                    if (Clipboard.GetText().All(c => ("0123456789()., " + ExpressionHolder.Operators).Contains(c)))
                    {
                        ExpressionHolder.Expression = Clipboard.GetText().Trim();
                        ExpressionDisplay_Label.Text = ExpressionHolder.Expression;
                        e.Handled = true;

                    }
                    else
                    {
                        ExpressionDisplay_Label.Text = ExpressionDisplay_Label.Text;
                    }
                }
            }


        }


        private bool WasResultPressed = false;

        // Logic for result button
        private void Result_Key_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ExpressionHolder.Expression))
            {
                return;
            }

            if (!WasResultPressed)
            {
                // Try catch to catch all exceptions thrown
                try
                {
                    // Empty label and append calculated result
                    ExpressionHolder.Expression = ExpressionDisplay_Label.Text;
                    ResultDisplay_Label.Text = string.Empty;
                    ResultDisplay_Label.Text += ExpressionHolder.CalculateResult(ExpressionHolder.Expression);
                    WasResultPressed = true;
                }
                catch (Exception ex)
                {
                    // Display exception message
                    string errorMessage = ex.Message;
                    ExpressionDisplay_Label.Text = errorMessage;
                    WasResultPressed = false;
                }
            }
            else
            {
                ExpressionHolder.Expression = ExpressionHolder.ContinuousResultCalculation(ResultDisplay_Label, ExpressionHolder.Expression);
                ExpressionDisplay_Label.Text = ExpressionHolder.Expression;
                ResultDisplay_Label.Text = string.Empty;
                ResultDisplay_Label.Text += ExpressionHolder.CalculateResult(ExpressionHolder.Expression);
                WasResultPressed = true;
            }

        }

        // Logic for clear button
        // Empty holder variable, then display its contents
        // Set result display as default 0
        private void Clear_Key_Click(object sender, EventArgs e)
        {
            ExpressionHolder.Expression = string.Empty;
            ExpressionDisplay_Label.Text = ExpressionHolder.Expression;
            ResultDisplay_Label.Text = "0";
            WasResultPressed = false;

        }

        // Logic for backspace button
        private void BackSpace_Btn_Click(object sender, EventArgs e)
        {
            // If string holder variable is not empty
            if (!string.IsNullOrEmpty(ExpressionHolder.Expression))
            {
                // Replace current value with substring short of last character
                ExpressionHolder.Expression = ExpressionHolder.Expression.Substring(0, ExpressionHolder.Expression.Length - 1);
                // Display updated values
                ExpressionDisplay_Label.Text = ExpressionHolder.Expression;
            }
        }

        private bool selectingStart = true;
        private async void CurrencyConversionCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (selectingStart)
            {
                if (e.Start > DateTime.Today || e.Start > DateTime.Parse(endDateLabel.Text))
                {
                    return;
                }
                startDateLabel.Text = e.Start.ToString("yyyy-MM-dd");
                endDateLabel.Text = DateTime.Today.ToString("yyyy-MM-dd");
                RefreshBestRate();
            }
            else
            {
                if (e.End > DateTime.Today || e.End < DateTime.Parse(startDateLabel.Text))
                {
                    return;
                }
                endDateLabel.Text = e.End.ToString("yyyy-MM-dd");
                RefreshBestRate();
            }

            selectingStart = !selectingStart;
        }

        private async void CurrencyCodesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshBestRate();
        }

        private async void RefreshBestRate()
        {
            if (CurrencyCodesComboBox.SelectedItem == null)
            {
                return;
            }

            string selectedCode = CurrencyCodesComboBox.SelectedItem.ToString();

            if (DateTime.TryParse(startDateLabel.Text, out DateTime start) &&
                DateTime.TryParse(endDateLabel.Text, out DateTime end))
            {
                await _currencyRatesService.FetchAndSaveCurrencyRatesAsync(selectedCode, start, end);
                var bestRate = _currencyRatesService.GetBestRate(selectedCode, start, end);
                CurrencyRateLabel.Text = bestRate.Rate.ToString();
            }
        }

        private void Convert_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ExpressionHolder.Expression))
            {
                return;
            }
            // Try catch to catch all exceptions thrown
            try
            {
                // Empty label and append calculated result
                ExpressionHolder.Expression = ExpressionDisplay_Label.Text;
                ResultDisplay_Label.Text = string.Empty;
                double preppedValue = ExpressionHolder.CalculateResult(ExpressionHolder.Expression);
                double convertedValue = preppedValue * (double.Parse(CurrencyRateLabel.Text));
                ResultDisplay_Label.Text = convertedValue.ToString("F2");
            }
            catch (Exception ex)
            {
                // Display exception message
                string errorMessage = ex.Message;
                ExpressionDisplay_Label.Text = errorMessage;
            }
        }

        private void Menu_Strip_Conversion_Click(object sender, EventArgs e)
        {
            if (!MainCurrencyConversionPanel.Visible)
            {
                HistoryDataGrid.Visible = false;
                MainCalculatorPanel.Visible = true;
                MainCurrencyConversionPanel.Visible = true;
            }
            else
            {
                HistoryDataGrid.Visible = false;
                MainCalculatorPanel.Visible = true;
                MainCurrencyConversionPanel.Visible = false;
            }
        }
    }
}
