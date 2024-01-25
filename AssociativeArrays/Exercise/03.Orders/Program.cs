using System.Collections.Concurrent;

class Programm
{
    class Product
    {
        public Product(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public void Update(decimal price, decimal quantity)
        {
            Price = price;
            Quantity += quantity;
        }
        public decimal GetTotal()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return $"{Name} -> {GetTotal():f2}";
        }


    }



    static void Main()
    {
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        string input = default;
        while ((input = Console.ReadLine()) != "buy")
        {
            string[] productArguments = input.Split();

            string name = productArguments[0];
            decimal price = decimal.Parse(productArguments[1]);
            decimal quantity = decimal.Parse(productArguments[2]);
                
            Product product = new Product(name, price, quantity);

            if (!products.ContainsKey(name))
            {
                products.Add(name, product);
            }
            else
            {
                products[name].Update(product.Price, product.Quantity);
            }
        }

        foreach (KeyValuePair<string, Product> kvp in products)
        {
            Console.WriteLine(kvp.Value);
        }
    }

}