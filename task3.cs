using System;
using System.Linq;

class Car
{
    public string Brand { get; }
    public int Year { get; }
    public int Mileage { get; private set; }

    public Car(string brand, int year)
    {
        Brand = brand;
        Year = year;
        Mileage = 0;
    }

    public void Drive(int km)
    {
        if (km > 0)
        {
            Mileage += km;
        }
        else
        {
            Console.WriteLine("Расстояние должно быть положительным числом.");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Марка: {Brand}, Год выпуска: {Year}, Пробег: {Mileage} км");
    }

    ~Car()
    {
        Console.WriteLine($"Объект автомобиля {Brand} уничтожен.");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car("Subaru", 2020);
        myCar.DisplayInfo();
        myCar.Drive(150);
        myCar.DisplayInfo();
    }
}
