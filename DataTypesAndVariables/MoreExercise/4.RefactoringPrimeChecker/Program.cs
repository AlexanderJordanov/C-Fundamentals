int n = int.Parse(Console.ReadLine());
for (int i = 2; i <= n; i++)
{
    bool inRange = true;
    for (int number = 2; number < i; number++)
    {
        if (i % number == 0)
        {
            inRange = false;
            break;
        }
    }
    Console.WriteLine($"{i} -> {inRange.ToString().ToLower()}");
}
