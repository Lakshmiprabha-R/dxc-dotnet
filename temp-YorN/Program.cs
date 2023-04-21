// See https://aka.ms/new-console-template for more information

    string input;
    do
    {
        Console.WriteLine("Enter Temperatue in Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine($"Temperature in Fahrenheit:{fahrenheit:F2}");
        Console.WriteLine("Do you want to continue? (yes or no):");
        input = Console.ReadLine();
    }
    while (input.ToLower() == "yes");


    

