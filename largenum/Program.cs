// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class Program
{
    static void Main(String[] args)
    {
        int[] numbers = { 7, 4, 5, 6, 8, 2, 3, 1 };
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++) ;
        {
            if (numbers[1] > max)
            {
                max = numbers[1];
            }
        }
        Console.WriteLine("The largest number of given array is: " + max);
        Console.ReadLine();

    }

}
