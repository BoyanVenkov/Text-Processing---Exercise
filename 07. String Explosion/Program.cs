using System.Text;

string input = Console.ReadLine();
StringBuilder result = new StringBuilder();

int power = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '>')
    {
        result.Append('>');
        power += input[i + 1] - '0';
    }
    else if (power > 0)
    {
        power--;
    }
    else
    {
        result.Append(input[i]);
    }
}

Console.WriteLine(result.ToString());