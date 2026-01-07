 string[] input = Console.ReadLine().Split(' ');

    string str1 = input[0];
    string str2 = input[1];

    int result = MultiplyCharacters(str1, str2);
    Console.WriteLine(result);

static int MultiplyCharacters(string str1, string str2)
{
    int sum = 0;
    int minLength = Math.Min(str1.Length, str2.Length);

    for (int i = 0; i < minLength; i++)
    {
        sum += str1[i] * str2[i];
    }

    if (str1.Length > str2.Length)
    {
        for (int i = minLength; i < str1.Length; i++)
        {
            sum += str1[i];
        }
    }
    else if (str2.Length > str1.Length)
    {
        for (int i = minLength; i < str2.Length; i++)
        {
            sum += str2[i];
        }
    }

    return sum;
}