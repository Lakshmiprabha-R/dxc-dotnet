// See https://aka.ms/new-console-template for more information

{
    Console.WriteLine("Temperature in Celsius\t Temperature in Fahrenheit");
    for (int celsius = 0; celsius <= 100; celsius += 10)
    {
        double fahrenheit = (celsius * 9 / 5.0) + 32;
        Console.WriteLine($"{celsius}C\t\t{fahrenheit}F");
    }
}


