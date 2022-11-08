using System;

namespace PracticeProblems
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Please Enter Your First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your Third Number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("Maximum Number is :" + a);
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("Maximum Number is " + b);
            }
            else
            {
                Console.WriteLine("Maximum Number is " + c);
            }
        }
    }
}