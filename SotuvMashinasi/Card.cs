using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotuvMashinasi
{
    public class Card
    {
        

        public Card(int cardId, double credit)
        {
            CardId = cardId;
            Credit = credit;
        }

        public int CardId { get; set; }
        public double Credit { get; set; }
        public void addCredit(double credit)
        {
            Credit+= credit;
        }
    }
}
