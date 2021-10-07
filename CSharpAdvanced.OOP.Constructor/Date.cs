using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.OOP.Constructor
{
    public class Date
    {
        private static readonly int[] dayesToMoth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] dayesToMoth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private readonly int day = 1;
        private readonly int moth = 1;
        private readonly int year = 1;


        public Date(int day, int moth , int year)
        {
            var isleap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            if (year >= 1 && year <= 9999 && moth >= 1 && moth <= 12)
            {
                int[] dayes = isleap ? dayesToMoth366 : dayesToMoth365;
                if (day >= 1 && day <= dayes[moth])
                {
                    this.day = day;
                    this.moth = moth;
                    this.year = year;
                }

            }
        }
        public Date(int year) : this (1,1,year)
        {

        }
        public string GetDate()
        {
            return $"{this.day.ToString().PadLeft(2, '0')}/{this.moth.ToString().PadLeft(2, '0')}/{this.year.ToString().PadLeft(4, '0')}";
        }

    }
}
