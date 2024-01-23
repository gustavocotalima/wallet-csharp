// the application should use inheritance to define the dollar and euro classes.
// the application should use generics to define the wallet class
//the user should be able to add funds to the wallet
//the user should be able to get the balance of the wallet in a specific currency
//the user should be able to exchange funds from one currency to another
//the user should be create a wallet with a specific currency amd add other currencies to it

namespace Wallet
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var wallet = new Wallet<Currency>();
            var dollar = new Dollar(200);
            var euro = new Euro(100);

            wallet.AddCurrency(dollar);
            wallet.AddCurrency(euro);

            Console.WriteLine($"Balance in USD: {wallet.GetBalance(dollar)}");
            Console.WriteLine($"Balance in EUR: {wallet.GetBalance(euro)}");

            wallet.ExchangeCurrency(dollar, euro, 50);

            Console.WriteLine($"Balance in USD: {wallet.GetBalance(dollar)}");
            Console.WriteLine($"Balance in EUR: {wallet.GetBalance(euro)}");
            
            wallet.AddFunds(euro, 50);
            
            Console.WriteLine($"Balance in USD: {wallet.GetBalance(dollar)}");
            Console.WriteLine($"Balance in EUR: {wallet.GetBalance(euro)}");
            
            wallet.ExchangeCurrency(euro, dollar, 50);
            
            Console.WriteLine($"Balance in USD: {wallet.GetBalance(dollar)}");
            Console.WriteLine($"Balance in EUR: {wallet.GetBalance(euro)}");
        }
    }
}

