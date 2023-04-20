namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator(+,-,*,/):");
            double op = Convert.ToChar(Console.ReadLine());
            double result = 0;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Divition by 0 is not allowded");
                        break;
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                        break;
                    }
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
        }
    }
}













        
       

    



