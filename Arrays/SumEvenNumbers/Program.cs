int[] array = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    int currentNumber = array[i];

    if (currentNumber % 2 == 0)
    {
        sum += currentNumber;
    }
}

Console.WriteLine(sum);