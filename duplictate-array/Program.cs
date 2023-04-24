// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1,3,5,7,9,2,4,6,8,1};
        int duplicates = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    duplicates++;
                    break;
                }
            }
        }

        Console.WriteLine("The number of duplicate values is: " + duplicates);
    }
}

