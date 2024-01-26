double budget = double.Parse(Console.ReadLine());

List<int> drums = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToList();

List<int> price = new List<int>();
price.AddRange(drums);

string command = string.Empty;

while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
{
    int hit = int.Parse(command);

    for (int i = 0; i < drums.Count; i++)
    {
        drums[i] -= hit;
        if (drums[i] <= 0)
        {
            if (budget - (price[i] * 3) >= 0)
            {
                budget = budget - (price[i] * 3);
                drums[i] = price[i];
            }
        }
    }

    for (int i = 0; i < drums.Count; i++)
    {
        if (drums[i] <= 0)
        {
            drums.Remove(drums[i]);
        }
    }
}
//foreach (var drum in drums)
//{
//    Console.Write(drum + " ");
//}

Console.WriteLine(string.Join(" ", drums));
Console.WriteLine();
Console.WriteLine($"Gabsy has {budget:f2}lv.");


