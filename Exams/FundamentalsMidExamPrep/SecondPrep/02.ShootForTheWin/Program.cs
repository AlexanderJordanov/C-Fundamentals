class Programm
{
    static void Main()
    {
        List<int> targets = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int counter = 0;
        string input = default;
        while ((input = Console.ReadLine()) != "End")
        {
            int indexOfTarget = int.Parse(input);

            if (indexOfTarget < 0 || indexOfTarget >= targets.Count)
            {
                continue;
            }

            int shotTargetValue = targets[indexOfTarget];
            if (shotTargetValue == -1)
            {
                continue;
            }

            targets[indexOfTarget] = -1;
            counter++;

            for (int i = 0; i < targets.Count; i++)
            {
                if (targets[i] == -1)
                {
                    continue;
                }

                if (targets[i] > shotTargetValue)
                {
                    targets[i] -= shotTargetValue;
                }
                else
                {
                    targets[i] += shotTargetValue;
                }
            }
        }

        Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", targets)}");
    }
}