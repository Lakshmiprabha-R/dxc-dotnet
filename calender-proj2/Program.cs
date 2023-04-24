// See https://aka.ms/new-console-template for more information
using System;

namespace MonthlyCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month(Press 1 for Jan, 2 for Feb, 12 for Dec......):");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Year:");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Day of week(Press 1 for Mon, 2 for Tue, 7 for Sun......):");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());

            DateTime date = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);

            Console.WriteLine("\t   Calendar");
            Console.WriteLine(" S M Tu W Th F S");

            for (int i = 1; i < dayOfWeek; i++)
            {
                Console.Write("   ");
            }

            for (int i = 1; i <= daysInMonth; i++)
            {
                Console.Write("{0,2} ", i);

                if ((i + dayOfWeek - 1) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}

