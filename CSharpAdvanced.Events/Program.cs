using System;

namespace CSharpAdvanced.Events
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock("Amazon");
            stock.Price = 100;

            // Subscribe in Event
            stock.OnPriceChanged += Stock_OnPriceChanged;

            Console.WriteLine($"stock befor change price $ : { stock.Price}");

            stock.ChangePriceBy(0.0);
            stock.ChangePriceBy(0.4);
            stock.ChangePriceBy(-0.2);

            Console.WriteLine($"stock after change price $ : { stock.Price}");

            // UnSubscribe in Event
            stock.OnPriceChanged -= Stock_OnPriceChanged;


            // another write Subscribe Method
            stock.OnPriceChanged += (Stock stock, double oldPrice) =>
            {
                if (stock.Price > oldPrice)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{stock.Name} : {stock.Price}");
                }
                else if (stock.Price < oldPrice)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{stock.Name} : {stock.Price}");

                }
                else
                {
                    Console.WriteLine($"{stock.Name} : {stock.Price}");

                }
            };
            // ---------------------------------------------------------
            stock.ChangePriceBy(0.4);
            Console.ReadKey();
        }

        private static void Stock_OnPriceChanged(Stock stock, double oldPrice)
        {
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{stock.Name} : {stock.Price}");
            }
            else if (stock.Price < oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{stock.Name} : {stock.Price}");

            }
            else
            {
                Console.WriteLine($"{stock.Name} : {stock.Price}");

            }
        }
    }
}
