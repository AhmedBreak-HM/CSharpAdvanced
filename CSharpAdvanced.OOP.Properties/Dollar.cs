using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.OOP.Properties
{
    public class Dollar
    {
        private double amount;

        public double Price { get; set; } = 95;

        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                // Validation
                if (value < 0) amount = 0;
                else amount = Math.Round(value, 2);
            }
        }
    }
}
