namespace Wallet
{
    public abstract class Currency(string name, decimal rate, decimal amount)
    {
        public string Name { get; set; } = name;
        public decimal Rate { get; set; } = rate;
        public decimal Amount { get; set; } = amount;
    }

    public class Dollar(decimal amount) : Currency("USD", 1, amount);

    public class Euro(decimal amount) : Currency("EUR", 0.92m, amount);
}