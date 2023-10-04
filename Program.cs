using Coins;
using System.Text;
using System.Threading.Tasks;

namespace Conins
{
    public static class Program
    {
        static void Main()
        {
            int[] coinList = { 1, 5, 10, 25 }; // Penny, Nickel, Dime, Quarter
            int toatlAmountInCents = 100; // 1 dollar = 100 cents

            int changeWays = Coin.CountChanges(coinList, toatlAmountInCents);

            Console.WriteLine($"Number of ways to make change for $1: {changeWays}");

            Console.ReadLine();
        }
    }
}