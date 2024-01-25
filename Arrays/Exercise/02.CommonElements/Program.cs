string input = Console.ReadLine();

string[] firstArr = input.Split();

input = Console.ReadLine();

string[] secondArr = input.Split();

for (int i = 0; i < secondArr.Length; i++)
{
    for (int j = 0; j < firstArr.Length; j++)
    {
        if (secondArr[i] == firstArr[j])
        {
            Console.Write($"{secondArr[i]} ");
        }
    }
}