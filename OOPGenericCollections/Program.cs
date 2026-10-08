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
        CheckStackLenght(employees);

        List<Employee> externalEmployees = new List<Employee>();

        AddEmployees(externalEmployees);
        CheckExistence(externalEmployees, externalEmployees[5]);
        CheckExistence(externalEmployees, new Employee { Id = Guid.NewGuid(), Name = "Gustaf V.", Gender = Gender.Male, Salary = 30000 });

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
            Employee employeew = employees.Peek();
            employeew.PrintEmployeeInfo(employees);
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

    public static void CheckStackLenght(Stack<Employee> employees)
    {
        if (employees.Count >= 3)
        {
            Console.WriteLine("\nObject number 3 exits in the stack\n");
        }
        else
        {
            Console.WriteLine("\nObject number 3 does not exist in the stack\n");
        }
    }

    public static void CheckExistence(List<Employee> externalEmployees, Employee employee)
    {
        if (externalEmployees.Contains(employee))
        {
            Console.WriteLine($"{employee} object exist in the list");
        }
        else
        {
            Console.WriteLine($"{employee} object does not exist in the list");
        }
    }
}
