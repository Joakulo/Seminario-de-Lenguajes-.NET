int Fac(int n){
    for (int i=n; i>1; i--) n= n*(i-1);
    return n;
}

Console.WriteLine(Fac(5));

Console.ReadKey();