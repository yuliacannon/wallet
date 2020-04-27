using BusinessCardLibrary;
using System;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            Purse myPurse = new Purse();

            myPurse.ShowAllBusinessCards();
        }
    }

    class Purse
    {
        public BusinessCard card = new BusinessCard("Andrew Kowalski", "PLVision", "QA", "andrew.kovalski@plvision.eu");

        public void ShowAllBusinessCards()
        {
            Console.WriteLine("Business cards in purse:");
            foreach (BusinessCard card in new BusinessCard[] { card })
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
