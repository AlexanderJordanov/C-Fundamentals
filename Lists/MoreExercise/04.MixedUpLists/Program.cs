List<int> firstList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> secondList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> mixedList = new List<int>();

for (int i = 0; i < firstList.Count; i++)
{
    for (int j = secondList.Count - 1; j >= 0; j--)
    {
        if (firstList.Count > 0 && secondList.Count > 0)
        {
            mixedList.Add(firstList[i]);
            mixedList.Add(secondList[j]);
            firstList.RemoveAt(i);
            secondList.RemoveAt(j);
        }
    }
}

int[] range = new int[2];

if (firstList.Count > 0)
{
    range[0] = firstList[0];
    range[1] = firstList[1];
}
else if (secondList.Count > 0)
{
    range[0] = secondList[0];
    range[1] = secondList[1];
}

List< int > orderedMixedList = new List< int >();
if (range[0] > range[1])
{
    for (int i = 0; i < mixedList.Count; i++)
    {
        if (mixedList[i] < range[0] && mixedList[i] > range[1])
        {
            orderedMixedList.Add(mixedList[i]);
        }
    }
}
else if (range[1] > range[0])
{
    for (int i = 0; i < mixedList.Count; i++)
    {
        if (mixedList[i] < range[1] && mixedList[i] > range[0])
        {
            orderedMixedList.Add(mixedList[i]);
        }
    }
}

orderedMixedList.Sort();
Console.WriteLine(string.Join(" ", orderedMixedList));