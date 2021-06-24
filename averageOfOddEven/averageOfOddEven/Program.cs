using System;
using static System.Console;

namespace averageOfOddEven
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number, countOdd = 0, countEven = 0, sumOdd = 0, sumEven = 0;
            Write("Please enter a positive number, enter any negative number to exit!");
            number = Convert.ToInt32(ReadLine());

            while (number >= 0)
            {
                if (number % 2 == 0)
                {
                    countEven++;
                    sumEven += number;
                }
                else
                {
                    countOdd++;
                    sumOdd += number;
                }
                Write("Please enter a positive number, enter any negative number to exit!");
                number = Convert.ToInt32(ReadLine());
            }
            WriteLine("You have entered " + countOdd + " odd numbers");
            WriteLine("You have entered " + countEven + " even numbers");
            WriteLine("The sum of odd numbers is " + sumOdd);
            WriteLine("The sum of even numbers is " + sumEven);

            if (countOdd > 0)
            {
                WriteLine("The average of odd numbers is: " + ((double)sumOdd / countOdd));
            }
            if (countEven > 0)
            {
                WriteLine("The average of even numbers is: " + ((double)sumEven / countEven));
            }

            ReadLine();
        }
    }
}