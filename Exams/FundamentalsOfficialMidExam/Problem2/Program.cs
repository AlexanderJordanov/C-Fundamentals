class Programm
{
    static void Main()
    {/*
        Travel 10||Enemy 30||Repair 15||Titan
        50
        80
       */
        List<string>titan= Console.ReadLine().Split("||").ToList();
        int fuel = int.Parse(Console.ReadLine());
        int ammunition = int.Parse(Console.ReadLine());
        for (int i = 0; i < titan.Count; i++)
        {
            List<string> seperated = titan[i].Split().ToList();
            string command = seperated[0];
            if (command == "Travel")
            {
                int distance = int.Parse(seperated[1]);
                if (fuel - distance>= 0) //=?
                {
                    fuel -= distance;
                    Console.WriteLine($"The spaceship travelled {distance} light-years.");
                }
                else
                {
                    Console.WriteLine("Mission failed.");
                    return;
                }
            }
            else if (command == "Enemy")
            {
                int armour = int.Parse(seperated[1]);
                if (ammunition - armour >= 0)
                {
                    ammunition -= armour;
                    Console.WriteLine($"An enemy with {armour} armour is defeated.");
                }
                else
                {
                    if (fuel >= 2 * armour)
                    {
                        fuel -= 2 * armour;
                        Console.WriteLine($"An enemy with {armour} armour is outmaneuvered.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
            }
            else if (command == "Repair")
            {
                int repair = int.Parse(seperated[1]);
                fuel += repair;
                ammunition += repair * 2;
                Console.WriteLine($"Ammunitions added: {repair * 2}.");
                Console.WriteLine($"Fuel added: {repair}.");
            }
            else if (command == "Titan")
            {
                Console.WriteLine("You have reached Titan, all passengers are safe.");
                return;
            }
        }
    }

}