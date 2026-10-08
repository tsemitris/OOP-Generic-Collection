using System;

namespace OOPGenericCollections;

public enum Gender
{
    Male,
    Female
}

public class Employee
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "Unknown";

    public Gender Gender { get; set; }
    public int Salary { get; set; } = 0;

    public void PrintEmployeeInfo(Stack<Employee> employees)
    {
        Console.WriteLine($"Employee informations: \nID: {Id} \nName: {Name} \nGender: {Gender} \nSalary: {Salary}");
        Console.WriteLine($"\n---------------------- \nItems left in the stack - {employees.Count}\n---------------------- \n");
    }

    public void PrintEmployeeInfo()
    {
        Console.WriteLine($"Employee informations: \nID: {Id} \nName: {Name} \nGender: {Gender} \nSalary: {Salary} \n");
    }
}
