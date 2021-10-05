using CSharpAdvanced.Delegates.Models;
using System.Collections.Generic;

namespace CSharpAdvanced.Delegates
{
    public class EmployeeServices
    {
        public static List<Employee> Employees = new List<Employee>();

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

        public void PrintEmployeeWithCondition()
        {

        }
    }
}