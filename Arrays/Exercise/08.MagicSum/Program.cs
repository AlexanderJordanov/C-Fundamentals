int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int number = int.Parse(Console.ReadLine());


for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        int sum = array[i] + array[j];

        if (sum == number)
        {
            Console.WriteLine($"{array[i]} {array[j]}");
        }
    }
}