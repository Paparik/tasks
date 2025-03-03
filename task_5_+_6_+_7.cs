using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double[,] table = new double[10, 10];
        for (int a = 0; a < 10; a++)
        {
            for (int x = 0; x < 10; x++)
            {
                table[a, x] = (a + 1) * Math.Sin(x + 1);
            }
        }

        Console.Write("X\t");
        for (int x = 1; x <= 10; x++)
        {
            Console.Write(x + "\t");
        }
        Console.WriteLine();

        for (int a = 0; a < 10; a++)
        {
            Console.Write((a + 1) + " |\t");
            for (int x = 0; x < 10; x++)
            {
                Console.Write($"{table[a, x]:F2}\t");
            }
            Console.WriteLine();
        }
    }
}
