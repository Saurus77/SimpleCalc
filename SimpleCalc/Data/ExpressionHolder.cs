using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc.Data
{
    internal static class ExpressionHolder
    {
        public static string Expression = string.Empty;
        public static string Operators = "+-*/";

        // Calculates result based on methods from calculationlogic class
        public static double CalculateResult(string expression)
        {
            var tokens = Tokenizer.Tokenize(expression);
            return CalculationLogic.CountTokens(tokens);
        }



        public static void CheckFirstChar(string expression, string buttonText)
        {
            if (string.IsNullOrEmpty(expression))
            {
                if (ExpressionHolder.Operators.Contains(buttonText))
                {
                    ExpressionHolder.Expression += "0" + buttonText;
                }
            }
        }

        // Used when input is an operator, fe.: *
        // Checks if last character in the expression string is not a number
        // fe.: 3+4- => 3+4 => 3+4*
        public static string CheckLastChar(string expression, string buttonText)
        {
            if (!string.IsNullOrEmpty(expression))
            {
                char lastChar = expression[^1];

                // If it's not a number, then removes it and adds input (operator)
                if (ExpressionHolder.Operators.Contains(lastChar))
                {
                    expression = expression.Substring(0, expression.Length - 1);
                }
            }
            // Returns modified expression
            expression += buttonText;
            return expression;
        }


        // Provides continuous result calculation based on:
        // Current result
        // Last number value
        // Last operator
        public static string ContinuousResultCalculation(System.Windows.Forms.Label resultLabel, string expression)
        {
            string currentResult = resultLabel.Text;
            string lastOperator = "";
            string lastNumber = "";

            // Loop through expression string last to first
            for (int i = expression.Length - 1; i >= 0; i--)
            {
                char ch = expression[i];

                // If character is not a number, then its a last operator
                if (ExpressionHolder.Operators.Contains(ch))
                {
                    if (ch == '-' && i > 0 && char.IsDigit(expression[i - 1]))
                    {
                        lastOperator = ch.ToString();
                    }
                    else if (ch != '-')
                    {
                        lastOperator = ch.ToString();
                    }

                    if (!string.IsNullOrEmpty(lastOperator))
                    {
                        lastNumber = expression.Substring(i + 1);
                        break;
                    }

                }
            }

            return currentResult + lastOperator + lastNumber;

        }
    }
}
