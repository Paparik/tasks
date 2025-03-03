using System;
using System.Linq;

static class Message
{
    public static void PrintShortWords(string text, int n)
    {
        var words = text.Split(new[] { ' ', '\t', '\n', '\r', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        var shortWords = words.Where(word => word.Length <= n);
        Console.WriteLine("Слова с длиной не более " + n + ": " + string.Join(", ", shortWords));
    }

    public static string RemoveWordsEndingWith(string text, char endingChar)
    {
        var words = text.Split(new[] { ' ', '\t', '\n', '\r', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        var filteredWords = words.Where(word => !word.EndsWith(endingChar.ToString()));
        return string.Join(" ", filteredWords);
    }

    public static string FindLongestWord(string text)
    {
        var words = text.Split(new[] { ' ', '\t', '\n', '\r', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.OrderByDescending(word => word.Length).FirstOrDefault() ?? "";
    }
}

class Program
{
    static void Main()
    {
        string message = "Пример текста с разными словами.";
        int maxLength = 5;
        char endingChar = 'а';

        Console.WriteLine("Исходное сообщение: " + message);
        Message.PrintShortWords(message, maxLength);
        Console.WriteLine("Сообщение после удаления слов на '" + endingChar + "': " + Message.RemoveWordsEndingWith(message, endingChar));
        Console.WriteLine("Самое длинное слово: " + Message.FindLongestWord(message));
    }
}