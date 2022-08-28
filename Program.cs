﻿namespace ProgramA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 for Flip Coin");
            Console.WriteLine("2 for Leap Year");
            Console.WriteLine("3 for Power2");
            Console.WriteLine("4 for Harmonic number");
            Console.WriteLine("5 for Prime Factor");
            int sh = Convert.ToInt32(Console.ReadLine());
            NewMethod(sh);
        }

        private static void NewMethod(int sh)
        {
            switch (sh)
            {
                case 1:
                    FlipCoin flipcoin = new FlipCoin();
                    flipcoin.Flip();
                    break;

                case 2:
                    LeapYear leap = new LeapYear();
                    leap.Leap();
                    break;

                case 3:
                    Power2 pow = new Power2();
                    pow.Power();
                    break;

                case 4:
                    HarmonicNumber har = new HarmonicNumber();
                    har.Harmonic();
                    break;

                case 5:
                    PFactors pri = new PFactors();
                    pri.Factor();
                    break;
            }
        }
    }
}