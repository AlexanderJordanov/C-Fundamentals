using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string inputLine = default;

            while ((inputLine = Console.ReadLine()) != "end")
            {
                string[] inputToken = inputLine.Split().ToArray();
                string command = inputToken[0];
                int number = int.Parse(inputToken[1]);

                if (command == "Add")
                {
                    list.Add(number);
                }
                else if (command == "Remove")
                {
                    list.Remove(number);
                }
                else if (command == "RemoveAt")
                {
                    list.RemoveAt(number);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(inputToken[2]);
                    list.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
