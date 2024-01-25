/*
2
Solmyr 85 120
Kyrre 99 50
Heal - Solmyr - 10
Recharge - Solmyr - 50
TakeDamage - Kyrre - 66 - Orc
CastSpell - Kyrre - 15 - ViewEarth
End

4
Adela 90 150
SirMullich 70 40
Ivor 1 111
Tyris 94 61
Heal - SirMullich - 50
Recharge - Adela - 100
CastSpell - Tyris - 1000 - Fireball
TakeDamage - Tyris - 99 - Fireball
TakeDamage - Ivor - 3 - Mosquito
End

*/
class Programm
{ 

    class Hero
    {
        public Hero(string name, int hp, int mp)
        {
            Name = name;
            HP = hp;
            MP = mp;
        }
        public string Name { get; set; }
        public int HP { get; set; } 
        public int MP { get; set; }

        public override string ToString()
        {
            string result = $"{Name}\n";
            result += $" HP: {HP}\n";
            result += $" MP: {MP}";
            return result;
        }
    }
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        List<Hero> party = new List<Hero>();

        for (int i = 0; i < number; i++)
        {
            string[] heroArgs = Console.ReadLine().Split().ToArray();

            string name = heroArgs[0];
            int hp = int.Parse(heroArgs[1]);
            int mp = int.Parse(heroArgs[2]);

            Hero hero = new Hero(name, hp, mp);
            party.Add(hero);
        }

        string input = default;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] actionArgs = input.Split(" - ");
            string action = actionArgs[0];
            string name = actionArgs[1];

            if (action == "CastSpell")
            {
                int mpNeeded = int.Parse(actionArgs[2]);
                string spell = actionArgs[3];

                Hero foundHero = party.FirstOrDefault(h => h.Name == name);

                if (foundHero.MP >= mpNeeded)
                {
                    foundHero.MP -= mpNeeded;
                    Console.WriteLine($"{foundHero.Name} has successfully cast {spell} and now has {foundHero.MP} MP!");
                }
                else
                {
                    Console.WriteLine($"{foundHero.Name} does not have enough MP to cast {spell}!");
                }
            }
            else if (action == "TakeDamage")
            {
                int damage = int.Parse(actionArgs[2]);
                string attacker = actionArgs[3];

                Hero foundHero = party.FirstOrDefault(h => h.Name == name);

                foundHero.HP -= damage;

                if (foundHero.HP <= 0)
                {
                    Console.WriteLine($"{foundHero.Name} has been killed by {attacker}!");
                    party.Remove(foundHero);
                }
                else
                {
                    Console.WriteLine($"{foundHero.Name} was hit for {damage} HP by {attacker} and now has {foundHero.HP} HP left!");
                }
            }
            else if (action == "Recharge")
            {
                int amount = int.Parse(actionArgs[2]);
                Hero foundHero = party.FirstOrDefault(h => h.Name == name);

                int diff = Math.Min(amount, 200 - foundHero.MP);

                foundHero.MP += amount;
                if (foundHero.MP > 200)
                {
                    foundHero.MP = 200;
                }

                Console.WriteLine($"{foundHero.Name} recharged for {diff} MP!");
            }
            else if (action == "Heal")
            {
                int amount = int.Parse(actionArgs[2]);
                Hero foundHero = party.FirstOrDefault(h => h.Name == name);

                int diff = Math.Min(amount, 100 - foundHero.HP);

                foundHero.HP += amount;
                if (foundHero.HP > 100)
                {
                    foundHero.HP = 100;
                }

                Console.WriteLine($"{foundHero.Name} healed for {diff} HP!");
            }
        }

        foreach (var hero in party)
        {
            Console.WriteLine(hero);
        }
    }

}