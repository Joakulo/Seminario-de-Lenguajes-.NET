void Fac(int n, out int f){
    for (int i=n; i>1; i--) n= n*(i-1);
    f = n;
}

int f;
Fac(5, out f);
Console.WriteLine(f);

Console.ReadKey();