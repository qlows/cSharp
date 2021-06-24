using System;
using static System.Console;
namespace _1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Write("Please enter a positive number: ");
            n = Convert.ToInt32(ReadLine());

            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            WriteLine("Sum of numbers from 1 to " + n + " is " + sum);
            ReadLine();
        }
    }
}
