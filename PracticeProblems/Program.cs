using System;

namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a no");
            int n = int.Parse(Console.ReadLine());
            EvenOdd(n);
        }
        public static void EvenOdd(int no)
        {

            if (no % 2 == 0)
            {
                Console.WriteLine("no is even");
            }
            else
            {
                Console.WriteLine("no is odd");
            }
        }
    }
}