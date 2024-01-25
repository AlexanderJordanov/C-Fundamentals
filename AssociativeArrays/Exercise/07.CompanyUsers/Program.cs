class Programm
{
    class Company
    {
        public Company(string name)
        {
            Name = name;
            Id = new List<string>();
        }
        public string Name { get; set; }
        public List<string> Id { get; set; }

        public override string ToString()
        {
            string result = Name + "\n";

            foreach (var item in Id)
            {
                result += $"-- {item}\n";
            }

            return result.Trim();
        }
    }
    static void Main()
    {
        Dictionary<string, Company> companies = new Dictionary<string, Company>();
        string input = default;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] arguments = input.Split(" -> ");
            string name = arguments[0];
            string id = arguments[1];

            if (!companies.ContainsKey(name))
            {
                companies.Add(name, new Company(name));
            }

            if (!companies[name].Id.Contains(id))
            {
                companies[name].Id.Add(id);
            }
        }

        foreach (var kvp in companies)
        {
            Console.WriteLine(kvp.Value);
        }
    }

}