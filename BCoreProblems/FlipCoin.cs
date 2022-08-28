using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCoreProblems
{
    public class FlipCoin
    {
        public void Flip()
        {
            // variables
            int head = 0;
            int tail = 0;

            Console.WriteLine("Enter the number of flips: ");
            int NUMBER_OF_FLIPS = Convert.ToInt32(Console.ReadLine());

            while (NUMBER_OF_FLIPS <= 0)
            {
                Console.WriteLine(" Invalid input, enter number greater than 0: ");
                Console.WriteLine("Please enter a number: ");
                NUMBER_OF_FLIPS = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < NUMBER_OF_FLIPS; i++)
            {
                Random flip = new Random();
                int HoT = flip.Next(0, 2);  // (0, 1)

                if (HoT < 0.5)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
            }
            float HEAD_PERCENT = (float)head / (float)NUMBER_OF_FLIPS;
            float TAIL_PERCENT = (float)tail / (float)NUMBER_OF_FLIPS;

            Console.WriteLine(HEAD_PERCENT + "is the % of times the result is head");
            Console.WriteLine(TAIL_PERCENT + "is the % of times the result is tail");

        }
    }
}
