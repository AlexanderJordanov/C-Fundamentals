int n = int.Parse(Console.ReadLine());
int totalLiters = 0;

for (int i = 0; i < n; i++)
{
    int quantity = int.Parse(Console.ReadLine());

    if (totalLiters + quantity > 255)
    {
        Console.WriteLine("Insufficient capacity!");
    }
    else
    {
        totalLiters += quantity;
    }
}

Console.WriteLine(totalLiters);
