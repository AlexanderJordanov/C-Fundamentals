class Programm
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        string input = default;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] studentTokens = input.Split();

            string firstName = studentTokens[0];
            string lastName = studentTokens[1];
            int age = int.Parse(studentTokens[2]);
            string homeTown = studentTokens[3];

            Student student = new Student();
            student.FirstName = firstName;
            student.LastName = lastName;
            student.Age = age;
            student.HomeTown = homeTown;

            students.Add(student);
        }

        string cityFilter = Console.ReadLine();

        for (int i = 0; i < students.Count; i++)
        {
            Student currentStudent = students[i];

            if (currentStudent.HomeTown == cityFilter)
            {
                Console.WriteLine(
                    $"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
            }
        }
    }


    public class Student
    {
        public Student()
        {

        }

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; } 
        public string HomeTown { get; set; }
    }

}