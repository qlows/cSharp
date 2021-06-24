using System;
using static System.Console;

namespace _2toN
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n1, n2, temp, sum = 0;
            Write("Please enter a positive number: ");
            n1 = Convert.ToInt32(ReadLine());

            Write("Please enter another positive number: ");
            n2 = Convert.ToInt32(ReadLine());

            if (n1 > n2)
            {
                temp = n1;
                n1 = n2;
                n2 = temp;
            }
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
            WriteLine("Sum of numbers from " + n1 + " to " + n2 + " is " + sum);
            ReadLine();
        }
    }
}