using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramA
{
    public class HarmonicNumber
    {
        public void Harmonic()
        {
            int i, n;
            double sum = 0.0;
            Console.WriteLine("Enter the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            // (1/1 +1/2 +..... 1/n)
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("1/{0} + ", i);
                sum += 1 / (float)i;
            }
            Console.WriteLine("\nSum of Series upto {0} terms : {1} \n", n, sum);
        }
    }
}
