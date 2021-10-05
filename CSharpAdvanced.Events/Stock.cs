using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Events
{
    public class Stock
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Stock(string name)
        {
            this.Name = name;
        }

        // step 1
        public delegate void StockPriceChangeHandler(Stock stock, double oldPrice);

        // step 2
        public event StockPriceChangeHandler OnPriceChanged;

        public void ChangePriceBy(double prcent)
        {
            var oldPrice = this.Price;
            this.Price += Math.Round(Price * prcent, 2);

            if (OnPriceChanged !=null) // make sure there Subscriber
            {
                // step 3
                OnPriceChanged(this, oldPrice);
            }
        }
    }
}
