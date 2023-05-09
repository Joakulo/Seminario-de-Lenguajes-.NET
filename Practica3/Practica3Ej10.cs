double pi = 3.141592653589793;

string format = String.Format("{0:F4}, {0:0.0000}, {0:.####}", pi);
Console.WriteLine(format);

string interpolado = $"{pi:F4}, {pi:0.0000}, {pi:.####}";
Console.WriteLine(interpolado);

Console.ReadKey();