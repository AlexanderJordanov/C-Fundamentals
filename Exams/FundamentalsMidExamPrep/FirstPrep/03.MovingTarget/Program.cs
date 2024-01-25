using System;

class Programm
{
    static void Main()
    {
        List<int> targets = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string input = default;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] arguments = input.Split();
            string command = arguments[0];
            int index = int.Parse(arguments[1]);

            if (command == "Shoot")
            {
                int power = int.Parse(arguments[2]);

                if (index >= 0 && index < targets.Count)
                {
                    targets[index] -= power;

                    if (targets[index] < 0)
                    {
                        targets.RemoveAt(index);
                    }
                }

            }
            else if (command == "Add")
            {
                int value = int.Parse(arguments[2]);

                if (index >= 0 && index < input.Length)
                {
                    targets.Insert(index, value);
                }
                else
                {
                    Console.WriteLine("Invalid placement!");
                }
            }
            else if (command == "Strike")
            {
                int radius = int.Parse(arguments[2]);

                if (index - radius >= 0 && index + radius < targets[targets.Count - 1])
                {
                    targets.RemoveRange(index - radius, radius * 2 + 1);
                }
                else
                {
                    Console.WriteLine("Strike missed!");
                }
            }
        }

        Console.WriteLine(string.Join("|", targets));
    }

}