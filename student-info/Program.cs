// See https://aka.ms/new-console-template for more information
using System.Xml.Schema;

Console.WriteLine("Enter the Student id");
int id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Student Name");
String Name = Console.ReadLine();
Console.WriteLine("enter the Student Age");
int Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Mark1:");
int mark1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Mark2:");
int mark2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Mark3:");
int mark3 = Convert.ToInt32(Console.ReadLine());

int total = mark1 + mark2 + mark3;
int avg = total / 3;
int per = avg / 3;
per = (total / 300) * 100;
Console.WriteLine("total marks are" + total);
Console.WriteLine("percentage is" + per);


    if (per >= 90 && per<=100)
    {
        Console.WriteLine("a grade");
    }
    else if (per >= 80 && per <= 88)
    {
        Console.WriteLine("b grade");
    }
    else if (per >= 60 && per <= 77)
    {
        Console.WriteLine("c grade");
    }
    else if (per >= 50 && per <= 55)
    {
        Console.WriteLine("d grade");
    }

if(per >= 50)
{
    Console.WriteLine("Result is pass");
} 
else
{
    Console.WriteLine("Result is fail");
}







