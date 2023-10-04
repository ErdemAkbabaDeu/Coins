using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    public static class Coin
    {
        /// <summary>
        /// Method definition to calculate how many ways are there to make change for a total amount of cents
        /// </summary>
        /// <param name="coinList"></param>
        /// <param name="totalAmount"></param>
        /// <returns></returns>
        public static int CountChanges(int[] coinList, int toatlAmountInCents)
        {
            int[] definitionList = new int[toatlAmountInCents + 1]; //Define a temp list
            definitionList[0] = 1; //Assign first element of the list as 1

            foreach (int coinItem in coinList) //Traverse the list
            {
                for (int i = coinItem; i <= toatlAmountInCents; i++)
                {
                    definitionList[i] += definitionList[i - coinItem]; //Increase and assign temp list's elements according to i and current coinItem
                }
            }

            return definitionList[toatlAmountInCents];
        }
    }
}