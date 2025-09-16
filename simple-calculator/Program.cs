using System;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();
                
                Console.WriteLine("Welcome to Simple Calculator\nEnter  your first number then press Enter:");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                
                Console.WriteLine("Enter  your Second number then press Enter:");
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                
                Console.WriteLine("Enter operation like + or add number then press Enter:");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);

                Console.WriteLine("The value " + firstNumber.ToString("0.00") + " " +
                                 operation + " the value " + secondNumber.ToString("0.00") +
                                 " is equal to " + result.ToString("0.00") + ".");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
