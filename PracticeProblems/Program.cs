using System;

namespace PracticeProblems
{
    internal class Program
    {
        public static void Main(String[] args)
        {


            Console.WriteLine("entre a value of a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a value of b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swapping Values of a & b:");
            Console.WriteLine($"a={a} \t b={b}");
            SwapNo(a, b);
        }
        public static void SwapNo(int x, int y)
        {
            int a = x;
            int b = y;
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after Swaping :");
            Console.WriteLine($"a={a} \t b={b}");


        }
    }
}