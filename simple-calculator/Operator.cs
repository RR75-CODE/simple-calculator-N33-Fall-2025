using System;

namespace SimpleCalculator
{
    public static class Operator
    {
        public static string ReadOperator(string input)
        {
            if (input == null)
            {
                HelpText();
                return null;
            }

            input = input.ToLower();

            if (input == "+" || input == "add" || input == "plus")
                return "+";
            else if (input == "-" || input == "subtract" || input == "minus")
                return "-";
            else if (input == "*" || input == "multiply" || input == "times")
                return "*";
            else if (input == "/" || input == "divide")
                return "/";
            else if (input == "^" || input == "power")
                return "^";
            else
            {
                Console.WriteLine("Invalid operation entered.");
                HelpText();
                return null;  
            }
        }

            public static void HelpText()
        {
            Console.WriteLine("Please enter one of these:");
            Console.WriteLine(" +   (or 'add', 'plus')");
            Console.WriteLine(" -   (or 'subtract', 'minus')");
            Console.WriteLine(" *   (or 'multiply', 'times')");
            Console.WriteLine(" /   (or 'divide')");
            Console.WriteLine(" ^   (or 'power')");
        }
    }
}

