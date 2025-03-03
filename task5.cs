using System;

class Program
{
    static void Main()
    {
        DateTime startTime = DateTime.Now;
        int count = 0;
        Console.WriteLine("Начало подсчёта " + startTime);
        for (int i = 1; i <= 1_000_000_000; i++)
        {
            if (IsGoodNumber(i))
            {
                count++;
            }
        }

        DateTime endTime = DateTime.Now;
        TimeSpan duration = endTime - startTime;

        Console.WriteLine($"Количество хороших чисел: {count}");
        Console.WriteLine($"Время выполнения: {duration}");
    }

    static bool IsGoodNumber(int num)
    {
        int sumOfDigits = GetSumOfDigits(num);
        return sumOfDigits != 0 && num % sumOfDigits == 0;
    }

    static int GetSumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}