// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 7, 7, 7, 7, 8, 8, 8, 5, 5, 5, 5, 6, 6, 6, 6 };
        Dictionary<int, int> count = new Dictionary<int, int>();
        int maxCount = 0;
        int mostFrequent = 0;

        foreach (int num in arr)
        {
            if (count.ContainsKey(num))
            {
                count[num]++;
            }
            else
            {
                count[num] = 1;
            }

            if (count[num] > maxCount)
            {
                maxCount = count[num];
                mostFrequent = num;
            }
        }

        Console.WriteLine($"The most frequent element is {mostFrequent}");
    }
}
