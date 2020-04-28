namespace MoneyLibrary
{
    public class Money
    {
        public string Currency { get; private set; }
        public double Amount { get; private set; }

        public Money(string currency, double amount)
        {
            this.Currency = currency;
            this.Amount = amount;
        }

        public void AddMoney(double amount)
        {
            this.Amount += amount;
        }

        public void SubstractMoney(double amount)
        {
            this.Amount -= amount;
        }

        public override string ToString()
        {
            return $"{this.Amount} {this.Currency}";
        }
    }
}
