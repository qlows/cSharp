using System;
using static System.Console;
namespace weeklyPay
{
    class Program
    {
        static void Main(string[] args)
        {
            double hourlyRate, hoursWorked; //input
            double totalPay, regularPay, overtimePay = 0; //output

            Write("Please enter hours worked per week: ");
            hoursWorked = Convert.ToDouble(ReadLine());

            Write("Please enter the hourly rate: ");
            hourlyRate = Convert.ToDouble(ReadLine());

            if(hoursWorked <= 40)
            {
                regularPay = hoursWorked * hourlyRate;
            }
            else if(hoursWorked > 40 && hoursWorked <= 50)
            {
                regularPay = 40 * hourlyRate;
                overtimePay = (hoursWorked - 40) * 1.5 * hourlyRate;
            }
            else if(hoursWorked > 50 && hoursWorked <= 60)
            {
                regularPay = 40 * hourlyRate;
                overtimePay = 10 * 1.5 * hourlyRate + (hoursWorked - 50) * 2.0 * hourlyRate;
            }
            else
            {
                regularPay = 40 * hourlyRate;
                overtimePay = 10 * 1.5 * hourlyRate + 10 * 2.0 * hourlyRate + (hoursWorked - 60) * 2.5 * hourlyRate;
            }
            totalPay = regularPay + overtimePay;

            WriteLine("Regular Pay: $" + regularPay);
            WriteLine("Overtime Pay: $" + overtimePay);
            WriteLine("Total Pay: $" + totalPay);
            ReadLine();

        }
    }
}
