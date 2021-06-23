using System;
using static System.Console;

namespace bigSmallNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num1, num2, num3;
            int min, max;
            int sum;

            Write("Enter the first number: ");
            num1 = Convert.ToInt32(ReadLine());

            Write("Enter the second number: ");
            num2 = Convert.ToInt32(ReadLine());

            Write("Enter the third number: ");
            num3 = Convert.ToInt32(ReadLine());

            min = Math.Min(num1, Math.Min(num2, num3));
            max = Math.Max(num1, Math.Max(num2, num3));

            sum = max - min;

            WriteLine("The biggest number is: " + max);
            WriteLine("The smallest number is: " + min);
            WriteLine("Sum of the biggest and smallest number is: " + sum);
           
            ReadLine();
        }
    }
}