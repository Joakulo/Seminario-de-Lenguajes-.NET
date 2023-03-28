Console.WriteLine("Ingrese un numero");
int a = 365 * int.Parse(Console.ReadLine());
string valor = a.ToString();

for (int i = 0; i<valor.Length; i++)
{
    Console.Write(valor[i] + " ");
}

Console.ReadKey();