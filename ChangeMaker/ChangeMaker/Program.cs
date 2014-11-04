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
            int counter = 0;

            //These paralell arrays correspond to each other, so that the value -> label indexes correlate. 
            double[] value = { 100, 50, 20, 10, 5, 1, .25, .10, .05, .01 };
            string[] label = { "$100s", "$50s", "$20s", "$10s", "$5s", "$1s", "Quarters", "Dimes", "Nickles", "Pennies" };

            //Write amount to console before we manipulate it.
            Console.WriteLine("Amount: " + amount);

            //For every value in our above arrays, subtract from the value until it is about to reach 0, iterating
            //the counter every time.
            for (int i = 0; i < value.Length; i++)
            {
                counter = 0;
                while(Math.Round(amount, 2) >= Math.Round(value[i], 2))
                {
                    counter++; //Every counter iteration means 1 more of the currency that we are currently on.
                    amount -= value[i];
                }

                Console.WriteLine("{0}: {1}", label[i], counter); //Print the info in the correct format.
            }
        }
    }
}
