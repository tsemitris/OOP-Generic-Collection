namespace OOPGenericCollections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        AddEmployess(employees);
    public static void AddEmployess(Stack<Employee> employees)
    {
        employees.Push(new Employee { Id = Guid.NewGuid(), Name = "Oskar L.", Gender = Gender.Male, Salary = 35000, });
        employees.Push(new Employee { Id = Guid.NewGuid(), Name = "Lucas D.", Gender = Gender.Male, Salary = 35000, });
        employees.Push(new Employee { Id = Guid.NewGuid(), Name = "Anna S.", Gender = Gender.Female, Salary = 32500, });
        employees.Push(new Employee { Id = Guid.NewGuid(), Name = "David S.", Gender = Gender.Male, Salary = 40000, });
        employees.Push(new Employee { Id = Guid.NewGuid(), Name = "Linnea R.", Gender = Gender.Female, Salary = 33000, });
    }
    }
}
