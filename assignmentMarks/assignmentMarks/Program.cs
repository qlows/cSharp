using System;
using static System.Console;

namespace assignmentMarks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int mark, counter = 0, sum = 0;

            Write("Please enter assignment mark from 0 to 100. (enter a negative value to exit): ");
            mark = Convert.ToInt32(ReadLine());

            while (mark >= 0)
            {
                if (mark <= 100)
                {
                    counter++;
                    sum += mark;
                }
                else
                {
                    WriteLine("The mark you have entered is out of range. 0-100 only!");
                }
                Write("Please enter assignment mark from 0 to 100. (enter a negative value to exit): ");
                mark = Convert.ToInt32(ReadLine());
            }

            WriteLine("You have entered " + counter + " marks.");

            if (counter > 0)
            {
                WriteLine("The average of these marks is " + ((double)sum / counter));
            }

            ReadLine();
        }
    }
}