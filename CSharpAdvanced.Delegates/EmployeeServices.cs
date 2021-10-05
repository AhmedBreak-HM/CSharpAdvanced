using System.Collections.Generic;
using CSharpAdvanced.Delegates.Models;

namespace CSharpAdvanced.Delegates
{
    public class EmployeeServices
    {
        public List<Employee> Employees = new List<Employee>();

        public EmployeeServices()
        {
            for (int i = 0; i < 51; i++)
            {
                Employees.Add(new Employee
                {
                    Id = i,
                    Name = $"Employee_NO_ {i}",
                    Salary = 1000 * (i + i)
                });
            }
        }

        public delegate bool FilterEmployee(Employee employee);

        public void PrintEmployeeWithCondition(List<Employee> employees, string title, FilterEmployee filterEmployee)
        {
            foreach (var emp in employees)
            {
                if (filterEmployee(emp))
                {
                    System.Console.WriteLine($"id = {emp.Id} - Name = {emp.Name} - Salary {emp.Salary}");
                }
            }
        }
    }
}