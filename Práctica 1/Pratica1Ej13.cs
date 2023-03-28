Console.WriteLine("Ingrese un numero");
string st = Console.ReadLine();
double a = double.Parse(st);

Console.WriteLine("Ingrese otro numero");
st = Console.ReadLine();
double b = double.Parse(st);

double c = a + b;
Console.WriteLine(c);

Console.ReadKey();