/*
9992 562 8933
This is some message for you
 */


List<int> num = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List< char > text = new List< char >();
text.AddRange(Console.ReadLine());

for (int i = 0; i < num.Count; i++)
{
    int sum = 0;

    while (num[i] != 0)
    {
        sum += num[i] % 10;
        num[i] /= 10;
    }

    int times = sum / text.Count;
    sum = sum - times * text.Count;

    Console.Write(text[sum]);

    text.RemoveAt(sum);
}
