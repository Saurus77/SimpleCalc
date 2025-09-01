using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalc.Data.Models;

namespace SimpleCalc.Data
{
    // Class encapsulating calculation logic:
    // - Operator priority
    // - Actual calculations
    // - Tokens evaluation from tokenizer
    internal static class CalculationLogic
    {
        // Checks priority of operator
        private static int OperatorPriority(string op)
        {
            return op switch
            {
                "+" or "-" => 1, // Lower priority
                "*" or "/" => 2, // Higher priority
                "^" => 3,
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
                _ => throw new Exception("Uknown operator")    // -> throws exception if operator unknown
            };
            Console.WriteLine(result);
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
                    continue;
                }

                switch (token)
                {
                    // If an operator is +,-,*,/ etc.
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        // As long as the stack is not empty and it's top operators priority is greater or equal to a given token
                        // (fe.: if token is "*" and top of the stack is "+" then ToTS operator has greater priority)
                        while (operatorsStack.Count > 0 && OperatorPriority(operatorsStack.Peek()) >= OperatorPriority(token))
                        {
                            // Keep performing operations and removing operators from the stack 
                            PerformOperation(numbersStack, operatorsStack.Pop());
                        }
                        // If peeked ToTS operator has lesser priority than given token, add token to the top of the stack
                        operatorsStack.Push(token);
                        break;

                    // If token is (, push it to operators stack
                    case "(":
                        operatorsStack.Push(token);
                        break;

                    // If token is ),
                    case ")":
                        // If ) is a first token, send ex
                        if (operatorsStack.Count == 0)
                        {
                            throw new Exception("Missmatched parentheses");
                        }

                        // Keep performing operations as long as there are operators
                        // and next operator is not a (
                        while (operatorsStack.Count > 0 && operatorsStack.Peek() != "(")
                        {
                            PerformOperation(numbersStack, operatorsStack.Pop());
                        }

                        // Remove (
                        // ) is never added to the stack, just triggers operations
                        operatorsStack.Pop();
                        break;
                }
            }
            // As long as there are operators remaining, keep performing operations
            // If there is no more numbers in the stack, result will be calculated by 0
            while (operatorsStack.Count > 0)
            {
                if(operatorsStack.Peek() == "(")
                {
                    throw new Exception("Missmatched parentheses");
                }
                PerformOperation(numbersStack, operatorsStack.Pop());
            }

            // If there are more than final result left, send ex
            if(numbersStack.Count != 1)
            {
                throw new Exception("Invalid Expression");
            }

            // Return final result and remove it from numbers stack
            double result = numbersStack.Pop();
            
            // Send calculation details to database
            CalculationHistoryLogic.AddToHistory(ExpressionHolder.Expression, result);

            return result;


        }
    }
}
