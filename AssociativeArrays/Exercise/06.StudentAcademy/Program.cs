/*
5
John
5.5
John
4.5
Alice
6
Alice
3
George
5
   
 */


class Programm
{
    class Student
    {
        public Student(string name)
        {
            Name = name;
            Grades = new List<decimal>();
        }
        public string Name { get; set; }
        public List<decimal> Grades { get; set; }

        public override string ToString()
        {
            return $"{Name} -> {Grades.Average():f2}";
        }
    }

    static void Main()
    {
        Dictionary<string, Student> students = new Dictionary<string, Student>();

        int pairs = int.Parse(Console.ReadLine());

        for (int i = 0; i < pairs; i++)
        {
            string name = Console.ReadLine();
            decimal grade = decimal.Parse(Console.ReadLine());

            if (!students.ContainsKey(name))
            {
                students.Add(name, new Student(name));
            }

            students[name].Grades.Add(grade);
        }

        IEnumerable<KeyValuePair<string, Student>> filteredStudents = students.Where(g => g.Value.Grades.Average() >= 4.50m);

        foreach (var kvp in filteredStudents)
        {
            Console.WriteLine(kvp.Value);
        }
    }
}