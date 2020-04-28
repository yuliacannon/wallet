using System;

namespace CreditCardLibrary
{
    public class CreditCard
    {
        public string HolderName { get; private set; }
        public string CardNumber { get; private set; }
        public double Balance { get; private set; }
        public string Currency { get; private set; }
        public string CVV { get; private set; }

        private Random random = new Random();

        public CreditCard(string holderName, double balance, string currency)
        {
            this.HolderName = holderName;
            this.Balance = balance;
            this.CardNumber = this.generateCardNumber();
            this.CVV = this.generateCVV();
            this.Currency = currency;
        }

        private string generateCVV()
        {
            return random.Next(0, 999).ToString("D3");
        }

        private string generateCardNumber()
        {
            Func<string> generate = () => random.Next(0, 9999).ToString("D4");
            return $"{generate()}-{generate()}-{generate()}-{generate()}";
        }

        public void AddMoney(double amount)
        {
            this.Balance += amount;
        }

        public void SubstractMoney(double amount)
        {
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Holder name: {this.HolderName}\n" +
                $"Balance: {this.Balance} {this.Currency}\n" +
                $"Card number: {this.CardNumber}\n";
        }
    }
}
