using System.Text;

string bigNumber = Console.ReadLine().Trim();
int multiplier = int.Parse(Console.ReadLine());

if (multiplier == 0 || bigNumber == "0")
{
    Console.WriteLine(0);
    return;
}

int carry = 0;
StringBuilder result = new StringBuilder();

for (int i = bigNumber.Length - 1; i >= 0; i--)
{
    int digit = bigNumber[i] - '0';
    int product = digit * multiplier + carry;

    result.Insert(0, product % 10);
    carry = product / 10;
}

if (carry > 0)
{
    result.Insert(0, carry);
}

Console.WriteLine(result.ToString().TrimStart('0'));