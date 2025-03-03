using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задание 5: Подсчет количества 'хороших' чисел");
        var startTime = DateTime.Now;
        int goodNumbersCount = CountGoodNumbers(1, 1_000_000_000);
        var endTime = DateTime.Now;
        Console.WriteLine($"Количество 'хороших' чисел: {goodNumbersCount}");
        Console.WriteLine($"Время выполнения: {(endTime - startTime).TotalSeconds} секунд\n");

        Console.WriteLine("Задание 6: Подсчет количества цифр числа");
        int number = 87346;
        int digitCount = CountDigits(number);
        Console.WriteLine($"Число: {number}, Количество цифр: {digitCount}\n");

        Console.WriteLine("Задание 7: Таблица значений функции a * sin(x)");
        PrintSinTable();
    }

    static int CountGoodNumbers(int start, int end)
    {
        int count = 0;
        object lockObj = new object();

        Parallel.For(start, end + 1, i =>
        {
            if (IsGoodNumber(i))
            {
                lock (lockObj)
                {
                    count++;
                }
            }
        });
        return count;
    }

    static bool IsGoodNumber(int num)
    {
        int sumDigits = num.ToString().Sum(c => c - '0');
        return sumDigits > 0 && num % sumDigits == 0;
    }

    static int CountDigits(int num)
    {
        return num.ToString().Length;
    }

    static void PrintSinTable()
    {
        Console.WriteLine("a\tx\ta*sin(x)");
        for (int a = 1; a <= 10; a++)
        {
            double x = a;
            double result = a * Math.Sin(x);
            Console.WriteLine($"{a}\t{x}\t{result:F5}");
        }
    }
}