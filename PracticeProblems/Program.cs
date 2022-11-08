using System;

namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("entre a no:");
            int no = int.Parse(Console.ReadLine());
            HarmonicNum(no);
        }
        public static void HarmonicNum(int n)
        {
            double series = 0;
            for (int i = 1; i <= n; i++)
            {
                series += 1 / (float)i;
            }
            Console.WriteLine($"Harmonic number : {series}");
        }
    }
}

