namespace ProgramA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 for Flip Coin");
            Console.WriteLine("2 for Leap Year");
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
            }
        }
    }
}