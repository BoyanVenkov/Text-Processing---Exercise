string[] usernames = Console.ReadLine().Split(", ");

foreach (string username in usernames)
{
    if (IsValid(username))
    {
        Console.WriteLine(username);
    }
}


static bool IsValid(string username)
{
    if (username.Length < 3 || username.Length > 16)
    {
        return false;
    }

    foreach (char ch in username)
    {
        if (!(char.IsLetterOrDigit(ch) || ch == '-' || ch == '_'))
        {
            return false;
        }
    }

    return true;
}