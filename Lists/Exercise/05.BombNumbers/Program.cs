/*
1 2 2 4 2 2 2 9
4 2

1 4 4 2 8 9 1
9 3
   
1 7 7 1 2 3
7 1
   
1 1 2 1 1 1 2 1 1 1
2 1
 */
class Programm
{
    static void Main()
    {
        List <int> list = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        List<int> bomb = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();


        int bombNumber = bomb[0];
        int powerOfBomb = bomb[1];

        while (list.Contains(bombNumber))
        {
            int indexOfBomb = list.IndexOf(bombNumber);

            int leftIndex = Math.Max(0, indexOfBomb - powerOfBomb);
            int rightIndex = Math.Min(list.Count - 1, indexOfBomb + powerOfBomb);

            int range = rightIndex - leftIndex + 1;

            list.RemoveRange(leftIndex, range);
        }

        Console.WriteLine(list.Sum());
    }

}
