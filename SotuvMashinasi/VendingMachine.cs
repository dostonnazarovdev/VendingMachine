using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotuvMashinasi
{
    public class VendingMachine
    {
        private Beverage[] beverageArray;
        private int beverageIndex = 0;

        private Card[] cardArray;
        private int cardIndex = 0;

        private Column[] columnArray;
        private int columnIndex = 0;

        public VendingMachine()
        {
            beverageArray=new Beverage[10];
            cardArray=new Card[10];
            columnArray=new Column[10];

        }

        public void addBeverage(string name, double price)
        {
            Beverage beverage = new Beverage(name, price);
            beverageArray[beverageIndex++] =beverage;


        }

        public double getPrice(string beverageName)
        {
            foreach (var item in beverageArray)
            {
                if (item.Name.Equals(beverageName))
                {
                    return item.Price;
                }
            }
            return -1;
        }

        public void rechargeCard(int cardId, double credit)
        {
            Card card = getCardById(cardId);

            if (card != null)
            {
                card.addCredit(credit);
                return;
            }
            cardArray[cardIndex++] = new Card(cardId, credit);
        }

        public Card getCardById(int cardId)
        {
            foreach (var item in cardArray)
            {
                if (item != null && item.CardId == cardId)
                {
                    return item;
                }
            }
            return null;
        }

        public double getCredit(int cardId)
        {
            Card card = getCardById(cardId);
            if (card != null)
            {
                return card.Credit;
            }
            return -1.0;
        }

        public void refillColumn(int colum, string beverageName, int cans)
        {
            Beverage beverage = getBeverageName(beverageName);
            if (beverage != null)
            {
                columnArray[columnIndex++] = new Column(colum, beverageName, cans);
            }

        }
        public Beverage getBeverageName(string beverageName)
        {
            foreach (var item in beverageArray)
            {
                if (item.Name.Equals(beverageName))
                {
                    return item;
                }

            }
            return null;
        }

        public int availableCans(string beverageName)
        {
            int count = 0;
            foreach (var item in columnArray)
            {
                if (item.BeverageName.Equals(beverageName))
                {
                    count += item.Cans;
                }
            }
            return count;
        }

        public int sell(String beverageName, int cardId)
        {
            return 0;
        }

       
    }
}
