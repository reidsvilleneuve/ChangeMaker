using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call ChangeMaker with values specified in the assignment, newlines between each.

            ChangeMaker(3.18);
            Console.WriteLine();
            ChangeMaker(0.99);
            Console.WriteLine();
            ChangeMaker(12.93);
            Console.WriteLine();
            ChangeMaker(186.41); // Extra credit

            Console.ReadKey();
        }

        /// <summary>
        /// Accepts a dollar ammount and reports the amount of coins needed to reach that dollar amount
        /// </summary>
        /// <param name="amount">Dollar value to process.</param>
        static void ChangeMaker(double amount)
        {
            amount = Math.Round(amount, 2); // Quick input validation. Rounds to the nearest 10's position.
            double originalAmount = amount; // For proper reporting during output phase.

            int hundereds = 0;
            int fifties = 0;
            int twenties = 0;
            int tens = 0;
            int fives = 0;
            int ones = 0;
            int quarters = 0; //Each will be iterated as their respective ammount is subtracted off of the
            int dimes = 0;    //total value of amount.
            int nickles = 0;
            int pennies = 0;

            while(amount >= 100) // Remove the given dollar value from amount, then iterate the correct variable.
            {
                amount -= 100;
                hundereds++;
            }

            while(amount >= 50)
            {
                amount -= 50;
                fifties++;
            }

            while(amount >= 20)
            {
                amount -= 20;
                twenties++;
            }

            while(amount >= 10)
            {
                amount -= 10;
                tens++;
            }

            while(amount >= 5)
            {
                amount -= 5;
                fives++;
            }

            while(amount >= 1)
            {
                amount -= 1;
                ones++;
            }

            while(amount >= .25) //Coin values - same principle.
            {
                amount -= .25;
                quarters++;
            }

            while (amount >= .1) //Dimes
            {
                amount -= .1;
                dimes++;
            }

            while (amount >= .05) //Nickles
            {
                amount -= .05;
                nickles++;
            }

            while (Math.Round(amount, 2) > 0) //Pennies. Rounded again to fix bug that causes amount to be set to
            {                                 //0.00000000000002 more than it should be.
                amount -= .01;
                pennies++;
            }

            //Output as per asignment requirements.

            Console.WriteLine("Amount: {0}\n$100s: {1}\n$50s: {2}\n$20s: {3}\n$10s: {4}\n$5s: {5}\n$1s: {6}",
                originalAmount, hundereds, fifties, twenties, tens, fives, ones);
            Console.WriteLine("Quarters: {0}\nDimes: {1}\nNickles: {2}\nPennies: {3}",
                quarters, dimes, nickles, pennies);
        }
    }
}
