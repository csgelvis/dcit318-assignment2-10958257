using System;

// Interface
public interface IMovable
{
    void Move();
}

// Class that implements IMovable
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Class that implements IMovable
public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();
        bicycle.Move();
    }
}
