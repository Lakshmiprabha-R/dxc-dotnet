// See https://aka.ms/new-console-template for more information


{

    int n, sum = 0, m;
    Console.WriteLine("Enter numbers:");
    n = int.Parse(Console.ReadLine());
    while (n > 0)
    {
        m = n % 10;
        sum = sum + m;
        n = n / 10;
    }
    Console.WriteLine("Sum is = " + sum);
}
