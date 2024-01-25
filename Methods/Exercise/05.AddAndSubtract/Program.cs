using System;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sumOfFirstTwo = Addition(firstNumber, secondNumber);
            int result = Subtract(sumOfFirstTwo, thirdNumber);

            Console.WriteLine(result);
        }

        static int Addition(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int Subtract (int sumOfFirstTwo, int thirdNumber)
        {
            return sumOfFirstTwo - thirdNumber;
        }
    }
}
