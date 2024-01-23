namespace Wallet;

public class Wallet<T> where T : Currency
{
    private readonly List<T> _currencies = new List<T>();

    public void AddCurrency(T currency)
    {
        _currencies.Add(currency);
    }

    public decimal GetBalance(T currency)
    {
        return currency.Amount;
    }
    
    public void AddFunds(T currency, decimal amount)
    {
        Console.WriteLine($"Adding {amount} {currency.Name} to wallet...");
        currency.Amount += amount;
    }

    public void ExchangeCurrency(T fromCurrency, T toCurrency, decimal amount)
    {
        if (fromCurrency.Amount < amount)
        {
            Console.WriteLine($"Insufficient funds to exchange {amount} {fromCurrency.Name} to {toCurrency.Name}.");
            return;
        }
        Console.WriteLine($"Exchanging {amount} {fromCurrency.Name} to {toCurrency.Name}...");
        fromCurrency.Amount -= amount; 
        toCurrency.Amount += amount * toCurrency.Rate / fromCurrency.Rate;
    }
}