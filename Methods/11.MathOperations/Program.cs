using System;

namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case "/":
                    result = DivideNumbers (firstNumber, secondNumber);
                    break;
                case "*":
                    result = MultiplyNumbers (firstNumber, secondNumber);
                    break;
                case "+":
                    result = AddNumbers (firstNumber, secondNumber);
                    break;
                case "-":
                    result = SubtractNumbers (firstNumber, secondNumber);
                    break;
            }
            Console.WriteLine (result);
        }

        static double DivideNumbers (double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result;
        }
        static double MultiplyNumbers(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return result;
        }
        static double AddNumbers(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }
        static double SubtractNumbers(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result;
        }
    }
}
