string path = Console.ReadLine();

string file = path.Substring(path.LastIndexOf('\\') + 1);

int dotIndex = file.LastIndexOf('.');
string fileName = file.Substring(0, dotIndex);
string extension = file.Substring(dotIndex + 1);

Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {extension}");