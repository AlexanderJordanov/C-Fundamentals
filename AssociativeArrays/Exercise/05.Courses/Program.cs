class Programm
{
    static void Main()
    {
        Dictionary<string, Course> courses = new Dictionary<string, Course>();
        string input = default;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] studentArguments = input.Split(" : ");
            string courseName = studentArguments[0];
            string studentName = studentArguments[1];

            if (!courses.ContainsKey(courseName))
            {
                Course course = new Course(courseName);
                courses.Add(courseName, course);
            }

            courses[courseName].StudentNames.Add(studentName);
        }

        foreach (KeyValuePair<string, Course> kvp in courses)
        {
            Console.WriteLine(kvp.Value);
        }
    }

    class Course
    {
        public Course(string name)
        {
            Name = name;
            StudentNames = new List<string>();
        }
        public string Name { get; set; }
        public List<string> StudentNames { get; set; }

        public override string ToString()
        {
            string result = $"{Name}: {StudentNames.Count}\n";

            for (int i = 0; i < StudentNames.Count; i++)
            {
                result += $"-- {StudentNames[i]}\n";
            }

            return result.Trim();
        }
    }
}