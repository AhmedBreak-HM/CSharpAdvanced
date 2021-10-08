using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.OOP.Indexers
{
    public class IPAdress
    {

        public int[] Segments { get; set; } = new int[4];

        public int this [int index]
        {
            get => Segments[index];
            set { Segments[index] = value; }
        }

        public IPAdress(string ipAdress)
        {
            var segm = ipAdress.Split('.');

            for (int i = 0; i <= segm.Length; i++)
            {
                Segments[i] = int.Parse(segm[i]) ;
            }

        }
        public IPAdress(int segment1,int segment2, int segment3, int segment4)
        {
            Segments[0] = segment1;
            Segments[1] = segment2;
            Segments[2] = segment3;
            Segments[3] = segment4;

        }

        public string GetIPAdress() => string.Join('.', Segments);

    }
}
