// See https://aka.ms/new-console-template for more information
using System;
class program
{
    static void Main()
    {
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter element " + (i + 1) + ": ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum += arr[i];
        }
        double avg = (double)sum / 10;
        Console.WriteLine("The avg of the  elements in the array is: " + avg);
    }
}
