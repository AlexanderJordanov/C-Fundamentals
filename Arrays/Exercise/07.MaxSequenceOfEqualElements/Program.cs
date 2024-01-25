string[] array = Console.ReadLine().Split();
int longestSequenceCount = 0;
string longestSequenceSymbol = "";

for (int i = array.Length - 1; i >= 0; i--)
{
    int count = 1;

    for (int j = i - 1; j >= 0; j--)
    {
        if (array[i] == array[j])
        {
            count++;
            if (longestSequenceCount <= count) 
            { 
            longestSequenceCount = count;
            longestSequenceSymbol = array[i];
            }
        }
        else
        {
            break;
        }
    }
}

for (int i = 0; i < longestSequenceCount; i++)
{
    Console.Write($"{longestSequenceSymbol} ");
}
