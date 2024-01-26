using System;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            double powerNumber = double.Parse(Console.ReadLine());

            double result = PowerNumbers(baseNumber, powerNumber);
            Console.WriteLine(result);
        }

        static double PowerNumbers (double baseNumber, double powerNumber)
        {
            double result = Math.Pow(baseNumber, powerNumber);
            return result;
        }
    }
}
