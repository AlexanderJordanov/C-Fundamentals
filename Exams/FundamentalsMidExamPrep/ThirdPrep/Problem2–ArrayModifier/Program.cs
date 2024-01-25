int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

string input = default;
while ((input = Console.ReadLine()) != "end")
{
    string[] arguments = input.Split();
    string command = arguments[0];

    if (command == "swap")
    {
        int firstNumberIndex = int.Parse(arguments[1]);
        int secondNumberIndex = int.Parse(arguments[2]);

        int firstNumber = array[firstNumberIndex];
        int secondNumber = array[secondNumberIndex];

        array[firstNumberIndex] = secondNumber;
        array[secondNumberIndex] = firstNumber;
    }
    else if (command == "multiply")
    {
        int firstNumberIndex = int.Parse(arguments[1]);
        int secondNumberIndex = int.Parse(arguments[2]);

        array[firstNumberIndex] *= array[secondNumberIndex];
    }
    else if (command == "decrease")
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i]--;
        }
    }
}

Console.WriteLine(string.Join(", ", array));

