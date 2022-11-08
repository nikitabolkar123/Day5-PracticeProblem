using System;

namespace PracticeProblems
{
    internal class Program
    {
        static int hco = 0;
        static int tco = 0;

        static void Main(string[] args)
        {
            FlipCoin(4);
        }
        public static void FlipCoin(int n)
        {
            int temp = n;
            Random rnd = new Random();
            while (n != 0)
            {
                double random = rnd.NextDouble();
                if (random <= 0.5)
                {
                    tco = tco + 1;
                }
                else
                {
                    hco++;
                }
                n = n - 1;
            }
            Console.WriteLine((hco * 100) / temp);
            Console.WriteLine((tco * 100) / temp);


        }
    }
}