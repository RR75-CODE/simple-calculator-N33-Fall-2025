using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            if (argOperation == "+")
            {
                result = argFirstNumber + argSecondNumber;
            }
            
            else if (operation == "-")
                result = argfirstNumber - argsecondNumber;

            else if (operation == "*")
                result = argfirstNumber * argsecondNumber;

            else if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return 0;
                }
                result = argfirstNumber / argsecondNumber;
            }
          else if (operation == "^")
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
