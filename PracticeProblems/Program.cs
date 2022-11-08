using System;

namespace PracticeProblems
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a Year");
            int year = int.Parse(Console.ReadLine());
            IsleapYear(year);
        }
        public static void IsleapYear(int n)
        {
            if (((n % 4 == 0) && (n % 100 != 0)) || (n % 400 == 0))
            {
                Console.WriteLine("It is a Leap Year");
            }
            else
            {
                Console.WriteLine("Its not a Leap Year");
            }
        }
    }
}