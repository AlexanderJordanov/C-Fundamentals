string input = Console.ReadLine();

string[] array = input.Split(' ').ToArray();

for (int i = array.Length - 1; i >= 0; i--)
{
    Console.Write($"{array[i]} ");
}