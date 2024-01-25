/*
3
Arnoldii<->4
Woodii<->7
Welwitschia<->2
Rate: Woodii - 10
Rate: Welwitschia - 7
Rate: Arnoldii - 3
Rate: Woodii - 5
Update: Woodii - 5
Reset: Arnoldii
Exhibition
   
   
 */
class Programm 
{ 
    class Plant
    {
        public Plant(string name, decimal rarity)
        {
            Name = name;
            Rarity = rarity;
        }
        public string Name { get; set; }

        public decimal Rarity { get; set; }

        public decimal Rating { get; set; }

        public int RatingCounter { get; set; }
    }
    static void Main()
    {
        List<Plant> plants = new List<Plant>();

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string[] arguments = Console.ReadLine().Split("<->").ToArray(); 
            string name = arguments[0];
            decimal rarity = decimal.Parse(arguments[1]);

            var foundPlant = plants.FirstOrDefault(p => p.Name == name);
            if (foundPlant != null)
            {
                foundPlant.Rarity = rarity;
                continue;
            }

            Plant plant = new Plant(name, rarity);
            plants.Add(plant);        
        }

        string input = default;
        while((input = Console.ReadLine()) != "Exhibition")
        {
            string[] arguments = input.Split(": ");
            string command = arguments[0];

            if (command == "Rate")
            {
                string[] plantArguments = arguments[1].Split(" - ");
                string name = plantArguments[0];
                decimal rating = decimal.Parse(plantArguments[1]);

                var foundPlant = plants.FirstOrDefault(p => p.Name == name);
                
                if (foundPlant != null) 
                {
                    foundPlant.Rating += rating;
                    foundPlant.RatingCounter++;
                    
                }
                else
                {
                    Console.WriteLine("error");
                    continue;
                }
            }
            else if (command == "Update")
            {
                string[] plantArguments = arguments[1].Split(" - ");
                string name = plantArguments[0];
                decimal newRarity = decimal.Parse(plantArguments[1]);
                var foundPlant = plants.FirstOrDefault(p => p.Name == name);

                if (foundPlant != null)
                {
                    foundPlant.Rarity = newRarity;

                }
                else
                {
                    Console.WriteLine("error");
                    continue;
                }
            }
            else if (command == "Reset")
            {
                string name = arguments[1];
                var foundPlant = plants.FirstOrDefault(p => p.Name == name);
                if (foundPlant != null)
                {
                    foundPlant.Rating = 0;
                    foundPlant.RatingCounter = 0;
                }
                else
                {
                    Console.WriteLine("error");
                    continue;
                }
            }
        }

        Console.WriteLine("Plants for the exhibition:");
        foreach (var plant in plants)
        {
            if (plant.RatingCounter == 0)
            {
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {plant.Rating:f2}");
            }
            else
            {
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {(plant.Rating/plant.RatingCounter):f2}");
            }
        }
    }
}
