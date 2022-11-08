using System;

namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre a no:");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"Factorial of {n} is {fact}");
        }
    }
}
