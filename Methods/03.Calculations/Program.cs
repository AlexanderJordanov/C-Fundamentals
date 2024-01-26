using System;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());    
            int secondNumber = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    AddNumbers(firstNumber, secondNumber);
                    break;
                case "multiply":
                    MultiplyNumbers(firstNumber, secondNumber);
                    break;
                case "subtract":
                    SubtractNumbers(firstNumber, secondNumber);
                    break;
                case "divide":
                    DivideNumbers(firstNumber, secondNumber);
                    break;
            }
        }


        static void AddNumbers (int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }

        static void MultiplyNumbers(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }
        static void SubtractNumbers(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }
        static void DivideNumbers(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
        }
    }
}
