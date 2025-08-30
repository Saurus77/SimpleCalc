using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.Internal;

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

                // If character is "." or ",", then if it's a first character in the holder variable: add preceding 0 => 0.1
                // Else ammend it to existing number 123.456
                else if (ch == '.' || ch == ',')
                {
                    if (number != "")
                    {
                        number += ch;
                    }
                    else
                    {
                        number += "0" + ch;
                    }

                }

                // If character is an operator
                else if ("+-*/".Contains(ch))
                {
                    // If number holder variable is not empty, add its value to the token list,
                    // Clear the variable and add operator to the token list
                    if (number != "")
                    {
                        tokensList.Add(number);
                        number = string.Empty;
                        tokensList.Add(ch.ToString());
                    }

                    // If an operator is the first item on the list, add extra zero before it => 0 +-/*
                    else if(i == 0)
                    {
                        tokensList.Add("0");
                        tokensList.Add(ch.ToString());
                    }
                    
                    // Else just add the operator
                    else
                    {
                        tokensList.Add(ch.ToString());
                    }

                }

                // If character is a left or right parenthesis and number holder variable is not empty,
                // Add holder variable value to the token list, clear its value and add the operator
                else if (ch == '(' || ch == ')')
                {
                    if (number != "")
                    {
                        tokensList.Add(number);
                        number = string.Empty;
                        tokensList.Add(ch.ToString());
                    }
                    else
                    {
                        tokensList.Add(ch.ToString());
                    }
                }

            }

            // If there is any lingering value in holder variable, add it as a token to the list
            if(number != string.Empty)
            {
                tokensList.Add(number);
            }

            // Normalize any values in token list which may consist of "," or "."
            for (int i = 0; i < tokensList.Count; i++)
            {
                tokensList[i] = tokensList[i].Replace(',', '.');
            }

            return tokensList;

        }
    }
}

