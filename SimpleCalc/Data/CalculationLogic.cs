using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc.Data
{
    // Class encapsulating calculation logic:
    // - Operator priority
    // - Actual calculations
    // - Tokens evaluation from tokenizer
    internal class CalculationLogic
    {
        // Checks priority of operator
        private static int OperatorPriority(string op)
        {
            return op switch
            {
                "+" or "-" => 1, // Lower priority
                "*" or "/" => 2, // Higher priority
                _ => 0 // Default (any) other character
            };
        }



        // Performs operations on numbers and returns final result
        private static void PerformOperation(Stack<double> numbersStack, string op)
        {
            // Takes two consecutive numbers off of stack,

            // Default declaration - used when user inputs only operator
            double right = 0;
            double left = 0;

            // If there are at least two numbers on the stack (regular option)
            if (numbersStack.Count >= 2)
            {
                right = numbersStack.Pop(); // Take top number
                left = numbersStack.Pop(); // Take second top number
            }

            // If there is only one number fe.: "10 -"
            else if (numbersStack.Count == 1)
            {
                right = numbersStack.Pop();
                left = right;
            }

                // Then performs appropriate operations based on the operator sign,
                double result = op switch
                {
                    "+" => left + right,
                    "-" => left - right,
                    "*" => left * right,
                    "/" => left / right,
                    "(" => 0,
                    _ => throw new Exception("Uknown operator")    // -> throws exception if operator unknown
                };
            numbersStack.Push(result);  // -> pushes result of operation on top of numbers stack
        }

        internal static double CountTokens(List<string> tokensList)
        {
            var numbersStack = new Stack<double>(); // Stack for numbers
            var operatorsStack = new Stack<string>(); // Stack for operators

            // Loop through all tokes in given list
            for (int i = 0; i < tokensList.Count; i++)
            {
                string token = tokensList[i];
                Console.WriteLine(token);
                // If token is a number, push it to numbers stack
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                
                    Console.WriteLine(number);
                    numbersStack.Push(number);
                }

                // If token is a left parenthesis, push it to operators stack
                else if (token == "(")
                {
                    operatorsStack.Push(token);
                }

                // If token is a right parenthesis,
                else if (token == ")")
                {
                    // If top operator is left parenthesis fe.: "()" situation
                    if (operatorsStack.Peek() == "(")
                    {
                        // Remove top operator and push 0 to numers stack as "()" is equal to "(0)"
                        operatorsStack.Pop();
                        numbersStack.Push(0);
                    }
                    else
                    {
                        // Keep checking if top token on operators stack is NOT a left parenthesis,
                        // (peek at last pushed onto the stack)
                        while (operatorsStack.Peek() != "(")
                        {
                            // As long as it is NOT - perform operations and keep removing operators from the stack
                            PerformOperation(numbersStack, operatorsStack.Pop());
                        }
                        Console.WriteLine(numbersStack.Count);
                        operatorsStack.Pop();
                    }
                    // If peeked token is a left parenthesis, simply remove it
     
                }

                // If token is a basic operator
                else if ("+-*/".Contains(token))
                {
                    // As long as the stack is not empty and it's top operators priority is greater or equal to a given token
                    // (fe.: if token is "*" and top of the stack is "+" then ToTS operator has greater priority)
                    while (operatorsStack.Count > 0 && OperatorPriority(operatorsStack.Peek()) >= OperatorPriority(token))
                    {
                        // Keep performing operations and removing operators from the stack 
                        PerformOperation(numbersStack, operatorsStack.Pop());
                    }
                    // If peeked ToTS operator has lesser priority than given token, add token to the top of the stack
                    operatorsStack.Push(token);
                }
            }
            // As long as there are operators remaining, keep performing operations
            // If there is no more numbers in the stack, result will be calculated by 0
            while (operatorsStack.Count > 0)
            {
                PerformOperation(numbersStack, operatorsStack.Pop());
            }

            // Return final result and remove it from numbers stack
            return numbersStack.Pop();

        }
    }
}
