namespace OOPGenericCollections;

class Program
{
    static void Main(string[] args)
    {
        Stack<Employee> employees = new Stack<Employee>();

        AddEmployess(employees);
        PrintEmployees(employees);
        RemoveAndPrintEmployees(employees);

        AddEmployess(employees);
        PrintTwoLatestEmployees(employees);
        CheckObjectExistence(employees, 3);

        List<Employee> externalEmployees = new List<Employee>();

        AddEmployees(externalEmployees);
        CheckExistence(externalEmployees, externalEmployees[4]);
        CheckExistence(externalEmployees, new Employee { Id = Guid.NewGuid(), Name = "Gustaf V.", Gender = Gender.Male, Salary = 30000 });

        FindMaleGender(externalEmployees);
        FindAllMaleGender(externalEmployees);

    }

    public static void AddEmployess(Stack<Employee> employees)
    {
        employees.Push(new Employee { Id = Guid.NewGuid(), Name = "Oskar L.", Gender = Gender.Male, Salary = 35000, });
        employees.Push(new Employee { Id = Guid.NewGuid(), Name = "Lucas D.", Gender = Gender.Male, Salary = 35000, });
        employees.Push(new Employee { Id = Guid.NewGuid(), Name = "Anna S.", Gender = Gender.Female, Salary = 32500, });
        employees.Push(new Employee { Id = Guid.NewGuid(), Name = "David S.", Gender = Gender.Male, Salary = 40000, });
        employees.Push(new Employee { Id = Guid.NewGuid(), Name = "Linnea R.", Gender = Gender.Female, Salary = 33000, });
    }

    public static void AddEmployees(List<Employee> externalEmployees)
    {
        externalEmployees.Add(new Employee { Id = Guid.NewGuid(), Name = "Oskar L.", Gender = Gender.Male, Salary = 35000, });
        externalEmployees.Add(new Employee { Id = Guid.NewGuid(), Name = "Lucas D.", Gender = Gender.Male, Salary = 35000, });
        externalEmployees.Add(new Employee { Id = Guid.NewGuid(), Name = "Anna S.", Gender = Gender.Female, Salary = 32500, });
        externalEmployees.Add(new Employee { Id = Guid.NewGuid(), Name = "David S.", Gender = Gender.Male, Salary = 40000, });
        externalEmployees.Add(new Employee { Id = Guid.NewGuid(), Name = "Linnea R.", Gender = Gender.Female, Salary = 33000, });
    }

    public static void PrintEmployees(Stack<Employee> employees)
    {
        foreach (Employee employee in employees)
        {
            employee.PrintEmployeeInfo(employees);
        }

        Console.WriteLine("--------------------------------------------");
    }

    public static void PrintTwoLatestEmployees(Stack<Employee> employees)
    {
        for (int i = 0; i < 2; i++)
        {
            Employee employee = employees.Peek();
            employee.PrintEmployeeInfo(employees);
        }
    }

    public static void RemoveAndPrintEmployees(Stack<Employee> employees)
    {
        int amountEmployees = employees.Count;
        for (int i = 0; i < amountEmployees; i++)
        {
            Employee employee = employees.Pop();
            employee.PrintEmployeeInfo(employees);
        }

        Console.WriteLine("--------------------------------------------");
    }

    public static void CheckObjectExistence(Stack<Employee> employees, int checkNumber)
    {
        if (employees.ElementAtOrDefault(checkNumber) != null)
        {
            Console.WriteLine($"\nObject number {checkNumber} exits in the stack\n");
        }
        else
        {
            Console.WriteLine($"\nObject number {checkNumber} does not exist in the stack\n");
        }
    }

    public static void CheckExistence(List<Employee> externalEmployees, Employee employee)
    {
        if (externalEmployees.Contains(employee))
        {
            Console.WriteLine($"{employee.Name} object exist in the list");
        }
        else
        {
            Console.WriteLine($"{employee.Name} object does not exist in the list");
        }
    }

    public static void FindMaleGender(List<Employee> externalEmployees)
    {
        Employee? externalMaleEmployee = externalEmployees.Find(e => e.Gender == Gender.Male);

        if (externalMaleEmployee != null)
        {
            externalMaleEmployee.PrintEmployeeInfo();
        }
        else
        {
            Console.WriteLine("I couldn't find any male employee.");
        }
    }

    public static void FindAllMaleGender(List<Employee> externalEmployees)
    {
        List<Employee> externalMaleEmployees = externalEmployees.FindAll(e => e.Gender == Gender.Male);

        if (externalMaleEmployees.Count > 0)
        {
            foreach (Employee employee in externalMaleEmployees)
            {
                employee.PrintEmployeeInfo();
            }
        }
        else
        {
            Console.WriteLine("I couldn't find any male employee.");
        }
    }
}
