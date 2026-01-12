using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("");
            return;
        }

        StringBuilder output = new StringBuilder();
        output.Append(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                output.Append(input[i]);
            }
        }

        Console.WriteLine(output.ToString());
    }
}