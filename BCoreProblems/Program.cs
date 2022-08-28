namespace BCoreProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 for Flip Coin");
            Console.WriteLine("2 for Harmonic number");
            Console.WriteLine("3 for Leap Year");
            Console.WriteLine("4 for Power2");
            Console.WriteLine("5 for Prime Factor");

            int Prog = Convert.ToInt32(Console.ReadLine());
            NewMethod(Prog);
        }

        private static void NewMethod(int Prog)
        {
            switch (Prog)
            {
                case 1:
                    FlipCoin flipcoin = new FlipCoin();
                    flipcoin.Flip();
                    break;

            }
        }
    }
}