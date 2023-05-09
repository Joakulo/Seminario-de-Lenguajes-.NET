Console.Write("Ingrese un numero: ");
int a = 365 * int.Parse(Console.ReadLine());
string valor = a.ToString();

for (int i = valor.Length-1; i>=0; i--) {
    Console.Write(valor[i] + " ");
}

Console.ReadKey();