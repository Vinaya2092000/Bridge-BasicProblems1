using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramA
{
    public class PFactors
    {
        public void Factor()
        {
            int num;

            Console.WriteLine("Enter the Number: ");

            num = int.Parse(Console.ReadLine());
            for (int i = 0; i*i <= num; i++)
            {
                if(num%i == 0)
                {
                    Console.WriteLine("", i);
                }
            }
            Console.WriteLine("Prime factor for " + num, "are: ", num);

        }
    }
}
