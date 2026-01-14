using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string[] tokens = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        double totalSum = 0;

        foreach (string token in tokens)
        {
            char firstLetter = token[0];
            char lastLetter = token[token.Length - 1];

            double number = double.Parse(
                token.Substring(1, token.Length - 2),
                CultureInfo.InvariantCulture);

            int firstPos = GetAlphabetPosition(firstLetter);
            int lastPos = GetAlphabetPosition(lastLetter);

            if (char.IsUpper(firstLetter))
                number /= firstPos;
            else
                number *= firstPos;

            if (char.IsUpper(lastLetter))
                number -= lastPos;
            else
                number += lastPos;

            totalSum += number;
        }

        Console.WriteLine(totalSum.ToString("F2"));
    }

    static int GetAlphabetPosition(char c)
    {
        if (char.IsUpper(c))
            return c - 'A' + 1;
        else
            return c - 'a' + 1;
    }
}