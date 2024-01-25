class Programm
{
/*
gold
155
silver
10
copper
17
gold
15
stop
*/
    static void Main()
    {
        Dictionary<string, uint> resourceQuantity = new Dictionary<string, uint>();

        string resource = "";
        while ((resource = Console.ReadLine()) != "stop")
        {
            uint quantity = uint.Parse(Console.ReadLine());

            if (!resourceQuantity.ContainsKey(resource))
            {
                resourceQuantity.Add(resource, 0);
            }

            resourceQuantity[resource] += quantity;
        }

        foreach (var kvp in resourceQuantity)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }

}