class Programm
{/*

4
Peter 120.00 Development
Tony 333.33 Marketing
Jony 840.20 Development
George 0.20 Nowhere

 */
    class Employee 
    {
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
        public string Name { get; set; }   
        public decimal Salary { get; set; }
    }

    class Department 
    {
        public Department(string depName)
        {
            DepName = depName;
        }
        public string DepName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public decimal TotalSalary { get; set; }

        public void AddNewEmployee (string empName, decimal empSalary)
        {
            TotalSalary += empSalary;

            Employees.Add(new Employee(empName, empSalary));
        }

    }


    static void Main()
    {
        List<Department> departments = new List<Department>();

        int lines = int.Parse(Console.ReadLine());

       for (int i = 0; i < lines; i++)
        {
            string[] input = Console.ReadLine().Split();  
            
            if (!departments.Any(d => d.DepName == input[2]))
            {
                departments.Add(new Department(input[2]));
            }

            departments.Find(d => d.DepName == input[2]).AddNewEmployee(input[0], decimal.Parse(input[1]));
        }

        Department bestDepartment = departments.OrderByDescending(d => d.TotalSalary / d.Employees.Count()).First();

        Console.WriteLine($"Highest Average Salary: {bestDepartment.DepName}");

        foreach (var employee in bestDepartment.Employees.OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
        }
    }
}
