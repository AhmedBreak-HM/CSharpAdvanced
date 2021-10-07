using System;

namespace CSharpAdvanced.OOP.Constructor
{
    static class Program
    {
        static void Main(string[] args)
        {
            var d1 = new Date(29,2,1999);
            var d2 = new Date( 1999);

            Console.WriteLine(d2.GetDate());

            var emp1 = new Employee();
            emp1.Id = 100;
            emp1.Name = "ahmed";
            Console.WriteLine($"{emp1.Id} - {emp1.Name}" );
            var emp2 = new Employee { Id = 105, Name = "Break" };
            Console.WriteLine($"{emp2.Id} - {emp2.Name}");

        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
