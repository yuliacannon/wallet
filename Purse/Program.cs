using BusinessCardLibrary;
using CreditCardLibrary;
using System;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            Purse myPurse = new Purse();

            myPurse.ShowAllBusinessCards();

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
    }
}
