class Programm
{
    static void Main()
    { 

        int days = int.Parse(Console.ReadLine());
        int players = int.Parse(Console.ReadLine());
        double energy = double.Parse(Console.ReadLine());
        double waterPerPerson = double.Parse(Console.ReadLine());
        double foodPerPerson = double.Parse(Console.ReadLine());


        double totalWater = days * players * waterPerPerson;
        double totalFood = days * players * foodPerPerson;
        bool noEnergy = false;

        for (int i = 1; i <= days; i++)
        {
            double energyLoss = double.Parse(Console.ReadLine());

            energy -= energyLoss;

            if (energy <= 0)
            {
                noEnergy = true;
                break;
            }

            if (i % 2 == 0)
            {
                energy = energy * 1.05;
                totalWater = totalWater * 0.7;
            }
            if (i % 3 == 0)
            {
                totalFood -= totalFood / (double)players;
                energy = energy * 1.1;
            }


        }

        if (noEnergy)
        {
            Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
        }

        else
        {
            Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
        }

    }

}