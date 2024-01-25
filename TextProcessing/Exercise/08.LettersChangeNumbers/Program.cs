class Programm
{
    static void Main()
    {
        string[] input = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        decimal totalSum = 0;

        foreach (string sequence in input)
        {
            char letterBefore = sequence[0];
            char letterAfter = sequence[sequence.Length - 1];
            decimal number = decimal.Parse(sequence.Substring(1, sequence.Length-2));

            decimal position;
            decimal result = 0;

            if (char.IsUpper(letterBefore))
            {
                position = (decimal)(letterBefore - 'A' + 1);
                result = number / position;
            }
            else if (char.IsLower(letterBefore))
            {
                position = (decimal)(letterBefore - 'a' + 1);
                result = number * position;
            }

            if (char.IsUpper(letterAfter))
            {
               position = (decimal)(letterAfter - 'A' + 1);
                result -= position;
            }
            else if (char.IsLower(letterAfter))
            {
                position = (decimal)(letterAfter - 'a' + 1);
                result += position;
            }
            totalSum += result;
        }

        Console.WriteLine($"{totalSum:f2}");
    }

}