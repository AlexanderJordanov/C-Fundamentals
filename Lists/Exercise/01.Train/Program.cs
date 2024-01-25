/*
32 54 21 12 4 0 23
75
Add 10
Add 0
30
10
75
end
   
*/
class Program
{
    static void Main()
    {
        List<int> train = Console.ReadLine()
           .Split()
           .Select(int.Parse)
           .ToList();

        int maxCapacity = int.Parse(Console.ReadLine());

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] arguments = input.Split();

            if (arguments[0] == "Add")
            {
                int passangers = int.Parse(arguments[1]);
                train.Add(passangers);
            }

            else
            {
                int newPassanger = int.Parse(arguments[0]);

                for (int i = 0; i < train.Count; i++)
                {
                    if (train[i] + newPassanger <= maxCapacity)
                    {
                        train[i] += newPassanger;
                        break;
                    }
                }
            }
        }

        Console.WriteLine(string.Join(" ", train));
    }

}