using BusinessCardLibrary;
using CreditCardLibrary;
using MoneyLibrary;
using System;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            Purse myPurse = new Purse();

            myPurse.ShowAllBusinessCards();

            myPurse.ShowAllMoney();

            double uahToAddAndSusbstract = 3300;
            Console.WriteLine($"\nAdding {uahToAddAndSusbstract}");
            myPurse.AddMoney(uahToAddAndSusbstract, myPurse.uah);
            Console.WriteLine($"New total: {myPurse.uah.ToString()}");
            Console.WriteLine($"\nSubstracting {uahToAddAndSusbstract}");
            myPurse.SubstractMoney(uahToAddAndSusbstract, myPurse.uah);
            Console.WriteLine($"New total: {myPurse.uah.ToString()}");

            double moneyToAddOrSubstract = 34.56;
            Console.WriteLine($"\nAdding {moneyToAddOrSubstract} to card: {myPurse.privatbank.CardNumber}");
            myPurse.AddMoneyToCard(moneyToAddOrSubstract, myPurse.privatbank);
            Console.WriteLine($"New total: {myPurse.privatbank.Balance} {myPurse.privatbank.Currency}");
            Console.WriteLine($"\nSubstracting {moneyToAddOrSubstract}");
            myPurse.SubstractMoneyFromCard(moneyToAddOrSubstract, myPurse.privatbank);
            Console.WriteLine($"New total: {myPurse.privatbank.Balance} {myPurse.privatbank.Currency}");
        }
    }

    class Purse
    {
        public BusinessCard card = new BusinessCard("Andrew Kowalski", "PLVision", "QA", "andrew.kovalski@plvision.eu");

        public CreditCard monobank = new CreditCard("Kate Black", 120000, "UAH");
        public CreditCard privatbank = new CreditCard("Ann Jane", 34000, "USD");

        public Money uah = new Money("UAH", 25000.75);
        public Money usd = new Money("USD", 35000);
        public Money eur = new Money("EUR", 23000);

        public void ShowAllBusinessCards()
        {
            Console.WriteLine("Business cards in purse:");
            foreach (BusinessCard card in new BusinessCard[] { card })
            {
                Console.WriteLine(card.ToString());
            }
        }
        public void AddMoneyToCard(double amountToAdd, CreditCard card)
        {
            card.AddMoney(amountToAdd);
        }

        public void SubstractMoneyFromCard(double amountToSubstract, CreditCard card)
        {
            card.SubstractMoney(amountToSubstract);
        }

        public void ShowAllCreditCards()
        {
            Console.WriteLine("Credit cards in purse:");
            foreach (CreditCard card in new CreditCard[] { monobank, privatbank })
            {
                Console.WriteLine(card.ToString());
            }
        }

        public void AddMoney(double amountToAdd, Money money)
        {
            money.AddMoney(amountToAdd);
        }

        public void SubstractMoney(double amountToSubstract, Money money)
        {
            money.SubstractMoney(amountToSubstract);
        }

        public void ShowAllMoney()
        {
            Console.WriteLine("Money in purse:");
            foreach (Money money in new Money[] { uah, usd, eur })
            {
                Console.WriteLine(money.ToString());
            }
        }
    }
}
