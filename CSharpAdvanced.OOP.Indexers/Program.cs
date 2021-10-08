using System;

namespace CSharpAdvanced.OOP.Indexers
{
    static class Program
    {
        static void Main(string[] args)
        {
            var ip1 = new IPAdress(112,114,55,32);
            var ip2 = new IPAdress("112.112.112.112");
            var fristSegment = ip1[1];
            Console.WriteLine(ip1.GetIPAdress());
            Console.WriteLine(fristSegment);
            Console.WriteLine(ip2.GetIPAdress());




        }
    }
}
