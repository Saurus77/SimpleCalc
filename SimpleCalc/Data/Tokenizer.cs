using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace SimpleCalc.Data
{
    // A class encapsulation tokenizer function
    internal static class Tokenizer
    {
        // A tokenizer function which splits expression string into specific elements like:
        // numbers, signs etc. in order to properly calculate given expression, fe.:
        // -2 - -2 as (-2) - (-2) = 0
        public static List<string> Tokenize(string expression)
        {
            // Create a list of tokens (string elements)
            var tokensList = new List<string>();
            string number = string.Empty;

            // Loop through expression string
            for (int i = 0; i < expression.Length; i++)
            {
                // Apply conditions for each character in the string
                char ch = expression[i];



                // If character is a digit, ammend it to a holder variable
                if (char.IsDigit(ch))
                {
                    number += ch;
                }


                // Switch for operators
                switch (ch)
                {
                    // If an operator is +,-,*,/ etc.
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        // If number variable is not empty, then add number token list and clear it
                        if (number != "")
                        {
                            tokensList.Add(number);
                            number = string.Empty;
                        }


                        // If operator is a -
                        // and there is more than 1 char in expression
                        // and its a first character
                        // and next char in expression is a digit
                        // then add - as a number element
                        if (expression.Length > 1 && i == 0 && ch == '-' && char.IsDigit(expression[i + 1]))
                        {
                            number += ch;
                            break;
                        }
                        else if (expression.Length > 1 && i > 0 && ch == '-' && expression[i - 1] == '(' && char.IsDigit(expression[i + 1]))
                        {
                            tokensList.Add("0");
                        }
                            // Finally add an operator as a token on top
                            tokensList.Add(ch.ToString());
                        break;

                    // If operator is a . or ,
                    case '.':
                    case ',':
                        // If number variable is not empty, then append it to the existing value
                        if (number != "")
                        {
                            number += ch;
                        }
                        // Or add preceding 0 if comma is first character
                        else
                        {
                            number += "0" + ch;
                        }
                        break;

                    // If operator is a (
                    case '(':
                        // If number variable is not empty, then add number token list and clear it
                        if (number != "")
                        {
                            tokensList.Add(number);
                            number = string.Empty;
                            tokensList.Add("*");
                        }
                        // If i > 0 and previous character in the string is a digit or )
                        // Then add preceding multiplication *
                        else if (i > 0 && expression[i - 1] == ')')
                        {
                            tokensList.Add("*");
                        }
                        // Finally add an operator as a token on top
                        tokensList.Add(ch.ToString());
                        break;

                    // If operator is a )
                    case ')':
                        // If number variable is not empty, then add number token list and clear it
                        if (number != "")
                        {
                            tokensList.Add(number);
                            number = string.Empty;
                        }

                        if (tokensList.Count > 0 && tokensList[tokensList.Count - 1] == "(")
                        {
                            throw new Exception("Invalid operation: Empty parentheses");
                        }
                        // Finally add an operator as a token on top
                        tokensList.Add(ch.ToString());
                        // If i > 0 and next character in the string is a digit or (
                        // Then add following multiplication *
                        if (i + 1 < expression.Length && (char.IsDigit(expression[i + 1]) || expression[i + 1] == '('))
                        {
                            tokensList.Add("*");
                        }
                  
                        break;

                }
            }

            // If there is any lingering value in number variable, add it as a token to the list
            if(number != string.Empty)
            {
                tokensList.Add(number);
            }

            // Normalize any values in tokens list which may consist of "," or "."
            for (int i = 0; i < tokensList.Count; i++)
            {
                tokensList[i] = tokensList[i].Replace(',', '.');
            }

            Console.WriteLine(string.Join(", ", tokensList));
            return tokensList;

        }
    }
}

