using System;
using static System.Console;

namespace sumAVGOfNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number, count = 0, limit, sum = 0;

            Write("How many numbers do you want enter? ");
            limit = Convert.ToInt32(ReadLine());
            while (count < limit)
            {
                Write("Please enter a positive number ");
                number = Convert.ToInt32(ReadLine());

                if (number > 0)
                {
                    sum += number;
                    count++;
                }
                else
                {
                    WriteLine("Positive numbers only. Try again!");
                }
            }
            WriteLine("The sum of the positive numbers you have entered is: " + sum);
            WriteLine("The average of these numbers is: " + ((double)sum / limit));
            ReadLine();
        }
    }
}