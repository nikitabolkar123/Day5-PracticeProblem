using System;

namespace PracticeProblems
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("entre a no");
            int no = int.Parse(Console.ReadLine());
            int temp = no;
            int power = 1;
            while (no != 0)
            {
                power = power * 2;
                no--;
            }
            Console.WriteLine($"Power of 2 ^ {temp} is : {power}");
        }
    }
}