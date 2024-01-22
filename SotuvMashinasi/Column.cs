using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotuvMashinasi
{
    public class Column
    {
        public Column(int colum, string beverageName, int cans)
        {
            Colum = colum;
            BeverageName = beverageName;
            Cans = cans;
        }

        public int Colum { get; set; }
        public string BeverageName { get; set; }
        public int Cans { get; set; }


    }
}
