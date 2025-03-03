using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Введите логин: ");
        string login = Console.ReadLine();

        if (IsValidLogin(login))
        {
            Console.WriteLine("Логин корректный.");
        }
        else
        {
            Console.WriteLine("Логин некорректный.");
        }
    }

    static bool IsValidLogin(string login)
    {
        string pattern = "^[A-Za-z][A-Za-z0-9]{1,9}$";
        return Regex.IsMatch(login, pattern);
    }
}
