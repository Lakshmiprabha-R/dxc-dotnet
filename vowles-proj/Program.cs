// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;

Console.WriteLine("Enter the character");
char ap = Convert.ToChar(Console.ReadLine());
if (ap == 'A' || ap == 'E' || ap == 'I' || ap == 'O' || ap == 'U') 
{
    Console.WriteLine("It's an vowel"); 
}

else
{
    Console.WriteLine("It's not an vowel");
}

