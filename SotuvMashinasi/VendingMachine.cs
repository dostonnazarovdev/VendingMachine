using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotuvMashinasi
{
    public class VendingMachine
    {
        private Beverage[] beverageArray = new Beverage[10];
        private int beverageIndex = 0;

        private Card[] cardArray = new Card[10];
        private int cardIndex = 0;

        private Column[] columnArray = new Column[10];
        private int columnIndex = 0;

        public VendingMachine()
        {

        }

        public void addBeverage(string name, double price)
        {
            Beverage beverage = new Beverage(name, price);
            beverageArray[beverageIndex++] = beverage;


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
                if (item != null && item.BeverageName.Equals(beverageName))
                {
                    count += item.Cans;
                }
            }
            return count;
        }

        public int sell(string beverageName, int cardId)
        {
            int cans = availableCans(beverageName);
            if (cans == 0)
            {
                return -1;
            }

            Card card = getCardById(cardId);
            if (card==null)
            {
                return -1;
            }

           double price= getPrice(beverageName);
            if (card.Credit < price)
            {
                return -1;
            }

            card.subtractPrice(price);
            Column column1 = new Column();

            foreach (var column in columnArray)
            {
                if (column != null && column.BeverageName.Equals(beverageName) && column.Cans>0)
                {
                    column.Cans = (column.Cans - 1);
                    return column.Colum;
                }
            }
            return -1;
        }


    }
}
