using System.Text.RegularExpressions;

class Programm
{
    class Furniture
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal GetTotal()
        {
            return Price * Quantity;
        }

    }
    static void Main()
    {
        List<Furniture> furnitures = new List<Furniture>();
        string pattern = @">>([A-z]+)<<(\d+\.\d+|\d+)!(\d+)";
        string input = default;
        while ((input = Console.ReadLine()) != "Purchase")
        {
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Furniture furniture = new Furniture();
                  furniture.Name = match.Groups[1].Value;
                  furniture.Price = decimal.Parse(match.Groups[2].Value);
                  furniture.Quantity = int.Parse(match.Groups[3].Value);
                  furnitures.Add(furniture);
            }
        }

        Console.WriteLine("Bought furniture:");
        decimal totalCost = 0;
        foreach (var furniture in furnitures)
        {
            Console.WriteLine(furniture.Name);
            totalCost += furniture.GetTotal();
        }

        Console.WriteLine($"Total money spend: {totalCost:f2}");
    }

}