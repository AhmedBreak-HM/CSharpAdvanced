using System;

namespace CSharpAdvanced.OOP.Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var d1 = new Dollar { Amount = -55 };
            Console.WriteLine(d1.Amount);
            Console.WriteLine(d1.Price);


        }
    }
}
