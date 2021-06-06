using System;
using static System.Console;


namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(5 + 8);
            WriteLine(5 * 8);
            WriteLine(8 - 5);
            WriteLine(5 % 2);// gives remainder
            WriteLine(5.0 + 8.2);
            WriteLine(6 + 54.7);
            WriteLine(5 / 2.0);//put .0 to get decimal answer

            int num = 6;
            //num++;
            WriteLine(num);

            WriteLine(Math.Abs(-40));
            WriteLine(Math.Pow(3, 2));
            WriteLine(Math.Sqrt(36));
            WriteLine(Math.Max(4, 90));//min gives smaller number
            WriteLine(Math.Round(4.4));


            ReadLine();
        }
    }
}
