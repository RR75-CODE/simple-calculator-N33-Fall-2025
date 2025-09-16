using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string Operation, double FirstNumber, double SecondNumber)
        {
            double result = 0;

            if (Operation == "+")
            {
                result = FirstNumber + SecondNumber;
            }
            
            else if (Operation == "-")
                result = firstNumber - secondNumber;

            else if (Operation == "*")
                result = firstNumber * secondNumber;

            else if (Operation == "/")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return 0;
                }
                result = firstNumber / secondNumber;
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
