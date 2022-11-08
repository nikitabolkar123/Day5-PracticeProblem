using System;

namespace PracticeProblems
{
    internal class Program
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("enter dividend:");
            int div = int.Parse(Console.ReadLine());
            Console.WriteLine("entre divisor:");
            int divisor = int.Parse(Console.ReadLine());
            int quotient = div / divisor;
            int rem = div % divisor;
            Console.WriteLine($" Qutient :{quotient}");
            Console.WriteLine($" Remender :{rem}");
        }
    }
}