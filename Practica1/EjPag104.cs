Console.WriteLine("Ingrese un numero:");

int n = int.Parse(Console.ReadLine());
int j=0;

for (int i=0; i<=n ; i++){
    j += i;
}

Console.WriteLine(j);
Console.ReadKey();