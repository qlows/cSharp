using System;
using static System.Console;

namespace working_w_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "GeorgeBrown" + " is cool"; 
            WriteLine(phrase);
            WriteLine("George\"Brown");
            WriteLine("George\nBrown");
            
            WriteLine(phrase.Length);
            WriteLine(phrase.ToUpper());
            WriteLine(phrase.Contains("Brown"));
            WriteLine(phrase[0]);
            WriteLine(phrase.IndexOf("Brown"));
            WriteLine(phrase.IndexOf('r'));
            WriteLine(phrase.Substring(6, 3));
        }
    }
}
