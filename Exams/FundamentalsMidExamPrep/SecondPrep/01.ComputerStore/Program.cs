using System.Diagnostics;

class Programm
{
    static void Main()
    {
        string input = Console.ReadLine();
        double totalPriceWithoutTax = 0;
        while (input != "special" && input != "regular") // &&/||?
        {
            double partPrice = double.Parse(input);
            totalPriceWithoutTax += partPrice;

            if (partPrice < 0) // <=?
            {
                Console.WriteLine("Invalid price!");
                totalPriceWithoutTax -= partPrice;
            }

            input = Console.ReadLine();
        }

        double taxes = totalPriceWithoutTax * 0.2;
        double totalPriceWithTaxes = totalPriceWithoutTax + taxes;

        if (input == "special")
        {
            totalPriceWithTaxes *= 0.9;
        }

        if (totalPriceWithTaxes <= 0)
        {
            Console.WriteLine("Invalid order!");
        }
        else
        {
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPriceWithoutTax:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPriceWithTaxes:f2}$");

        }
    }
}