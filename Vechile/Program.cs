using System;

public interface IVehiculo
{
    void Drive();
    bool Refuel(int amount);
}
public class Car : IVehiculo
{
    private int gasoline;

    public Car(int startingGasoline)
    {
        gasoline = startingGasoline;
    }

    public void Drive()
    {
        if (gasoline > 0)
        {
            Console.WriteLine("The car is driving.");
        }
    }

    public bool Refuel(int amount)
    {
        gasoline += amount;
        return true;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of gasoline to refuel: ");
        int gasoline = Convert.ToInt32(Console.ReadLine());

        Car car = new Car(0);
        car.Refuel(gasoline);
        car.Drive();

        Console.ReadKey();
    }
}
public class MyStack<T>
{
    private T[] stackArray;
    private int count;

    public MyStack()
    {
        stackArray = new T[10];
        count= -1;
    }

    public void Push(T obj)
    {
        if (count == stackArray.Length - 1)
        {
            Array.Resize(ref stackArray, stackArray.Length * 2);
        }

        count++;
        stackArray[count] = obj;
    }

    public T Pop()
    {
        if (count == -1)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T obj = stackArray[count];
        count--;
        return obj;
    }

    public int top
    {
        get { return count + 1; }
    }
}


