using System.Text.RegularExpressions;

class Programm
{
    class Order
    {
        public string Name { get; set; }
        public string Product { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }

    }

    static void Main()
    {
        string pattern = @"\%([A-Z][a-z]+)\%[^|$%.]*\<(\w+)\>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+(?:\.\d+)?)\$";

        string input = default;
        decimal totalIncome = 0;
        while ((input = Console.ReadLine()) != "end of shift")
        {
            if (Regex.IsMatch(input, pattern) == false)
            {
                continue;
            }

            Match match = Regex.Match(input, pattern);
            Order order = new Order();

            order.Name = match.Groups[1].Value;
            order.Product = match.Groups[2].Value;
            order.Count = int.Parse(match.Groups[3].Value);
            order.Price = decimal.Parse(match.Groups[4].Value);

            totalIncome += order.Price * order.Count;

            Console.WriteLine($"{order.Name}: {order.Product} - {(order.Price*order.Count):f2}");
        }
        Console.WriteLine($"Total income: {totalIncome:f2}");
    }

}