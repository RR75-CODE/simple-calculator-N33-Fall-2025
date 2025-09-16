using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            if (argOperation == "+" || argOperation.ToLower() == "add")
            {
                result = argFirstNumber + argSecondNumber;
            }
            
            else if (operation == "-" || operation == "subtract")
                result = firstNumber - secondNumber;

            else if (operation == "*" || operation == "multiply")
                result = firstNumber * secondNumber;

            else if (operation == "/" || operation == "divide")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return 0;
                }
                result = firstNumber / secondNumber;
            }
          else if (operation == "^" || operation == "power")
            {
                if (secondNumber < 0 || secondNumber % 1 != 0)
                {
                    Console.WriteLine("Only positive whole number exponents.");
                    return 0;
                }

                result = 1;
                for (int i = 0; i < (int)secondNumber; i++)
                {
                    result *= firstNumber;
                }
            }
            else
            {
                Console.WriteLine("Invalid operation.");
                return 0;
            }

            return result;
        }
    }
} 
