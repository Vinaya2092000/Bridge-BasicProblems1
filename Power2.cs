using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramA
{
    public class Power2
    {
        public void Power()
        {
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n < 0 || n >= 31)
            {
                Console.Write("Enter valid number: ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
  