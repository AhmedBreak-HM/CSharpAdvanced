namespace CSharpAdvanced.Delegates
{
    using CSharpAdvanced.Delegates.Models;
    using System;

    internal static class Program
    {
        internal static void Main(string[] args)
        {
            var emp = new EmployeeServices();

            emp.PrintEmployeeWithCondition(emp.Employees, "FilterBy > 1000",
                delegate (Employee employee) { return employee.Salary >= 20000; });

            emp.PrintEmployeeWithCondition(emp.Employees, "FilterBy > 1000",
                (employee) => employee.Salary >= 20000);

            emp.PrintEmployeeWithCondition(emp.Employees, "FilterBy > 1000",
                e => e.Salary >= 20000);
        }
    }
}