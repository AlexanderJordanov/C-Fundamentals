using System;

namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            double result = RectangleArea(sideA, sideB);

            Console.WriteLine(result);
        }

        static double RectangleArea (double sideA, double sideB)
        {
            double area = sideA * sideB;
            return area;
        }
    }
}
