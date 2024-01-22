

using System;

namespace SotuvMashinasi
{
    public class Program
    {
        private static VendingMachine vendingMachine;
        static void Main(string[] args)
        {
            vendingMachine = new VendingMachine();

            vendingMachine.addBeverage("Suv", 1000);
            vendingMachine.addBeverage("Fanta", 3300);
            vendingMachine.addBeverage("Sharbat", 1500);
            vendingMachine.addBeverage("Ayron", 1100);
            vendingMachine.addBeverage("Asal choy", 1100);
            vendingMachine.addBeverage("Coca Cola", 1100);


            Console.WriteLine("getPriceTest():   VendingMachine.getPrice()  " + getPriceTest());

            //# rechargeCard
            vendingMachine.rechargeCard(1, 2000);
            vendingMachine.rechargeCard(2, 15000);
            vendingMachine.rechargeCard(3, 25000);
            vendingMachine.rechargeCard(1, 2500);

            Console.WriteLine("getCreditTest():   VendingMachine.getCredit()  " + getCreditTest());



            vendingMachine.refillColumn(1, "Suv",13);
            vendingMachine.refillColumn(2, "Coca Cola", 10);
            vendingMachine.refillColumn(3, "Sharbat", 2);
            vendingMachine.refillColumn(4, "Suv", 8);


            Console.WriteLine("availableCansTest():   VendingMachine.availableCans()  " + availableCansTest());

          

            //Console.WriteLine("sellTest():   VendingMachine.sell()  " + sellTest());

        }

        private static bool getPriceTest()
        {

            double test1 = vendingMachine.getPrice("Suv");
            if (test1 != 1000)
            {
                Console.Error.WriteLine("getPriceTest: test1 ERROR");
                return false;
            }


            double test2 = vendingMachine.getPrice("Fanta");
            if (test2 != 3300)
            {
                Console.Error.WriteLine("getPriceTest: test2 ERROR");
                return false;
            }

            double test3 = vendingMachine.getPrice("Ayron");
            if (test3 != 1100)
            {
                Console.Error.WriteLine("getPriceTest: test3 ERROR");
                return false;
            }


            double test4 = vendingMachine.getPrice("Sharbat");
            if (test4 != 1500)
            {
                Console.Error.WriteLine("getPriceTest: test4 ERROR");
                return false;
            }
            return true;
        }

        private static bool getCreditTest()
        {
            double test1 = vendingMachine.getCredit(2);
            if (test1 != 15000)
            {
                Console.Error.WriteLine("getCreditTest: test1 ERROR");
                return false;
            }

            double test2 = vendingMachine.getCredit(1);
            if (test2 != 4500)
            {
                Console.Error.WriteLine("getCreditTest: test2 ERROR");
                return false;
            }
            double test3 = vendingMachine.getCredit(3);
            if (test3 != 25000)
            {
                Console.Error.WriteLine("getCreditTest: test3 ERROR");
                return false;
            }

            return true;
        }

        private static bool availableCansTest()
        {
            int test1 = vendingMachine.availableCans("Suv");
            if (test1 != 21)
            {
                Console.Error.WriteLine("availableCansTest: test1 ERROR");
                return false;
            }

            int test2 = vendingMachine.availableCans("Sharbat");
            if (test2 != 2)
            {
                Console.Error.WriteLine("availableCansTest: test2 ERROR");
                return false;
            }

            int test3 = vendingMachine.availableCans("Coca Cola");
            if (test3 != 10)
            {
                Console.Error.WriteLine("availableCansTest: test3 ERROR");
                return false;
            }

            return true;
        }

        private static bool sellTest()
        {
            int test1 = vendingMachine.sell("Suv", 2);
            if (test1 != 1)
            {
                Console.Error.WriteLine("sellTest: test1 ERROR");
                return false;
            }

            int test2 = vendingMachine.sell("Coca Cola", 1);
            if (test2 != 2)
            {
                Console.Error.WriteLine("sellTest: test2 ERROR");
                return false;
            }


            int test3 = vendingMachine.sell("Coca Cola", 1);
            if (test3 != -1)
            {
                Console.Error.WriteLine("sellTest: test3 ERROR");
                return false;
            }

            int test4 = vendingMachine.sell("Asal choy", 3);
            if (test4 != -1)
            {
                Console.Error.WriteLine("sellTest: test4 ERROR");
                return false;
            }


            return true;
        }
    }
}