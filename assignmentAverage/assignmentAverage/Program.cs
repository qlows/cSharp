using System;
using static System.Console;
namespace chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int assignment1, assignment2,
              assignment3, assignment4;

            Write("Please enter the mark for assignment 1: ");
            assignment1 = Convert.ToInt32(ReadLine());
            Write("Please enter the mark for assingment 2: ");
            assignment2 = Convert.ToInt32(ReadLine());
            Write("Please enter the mark for assignemnt 3: ");
            assignment3 = Convert.ToInt32(ReadLine());
            Write("Please enter the mark for assignment 4: ");
            assignment4 = Convert.ToInt32(ReadLine());

            double totalMark = assignment1 * 0.15 + assignment2 * 0.25 +
                assignment3 * 0.3 + assignment4 * 0.3;
            WriteLine("Total Marks: " + totalMark);
            ReadLine();

        }
    }
}
