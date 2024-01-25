class Programm 
{ 
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Family
    {
        public List<Person> family
        { get; set; } = new List<Person>();

        public void AddMember(string[] personInfo)
        {
            Person newPerson = new Person(personInfo[0], int.Parse(personInfo[1]));

            family.Add(newPerson);
        }

        public Person GetOlderPerson()
        {
            return family.OrderByDescending(p => p.Age).First();
        }
    }
    static void Main()
    {
        Family family = new Family();

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            family.AddMember(Console.ReadLine().Split());
        }

        Person oldestPerson = family.GetOlderPerson();

        Console.WriteLine(oldestPerson.Name + " " +  oldestPerson.Age);
    }
}
