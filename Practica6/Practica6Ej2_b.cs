using Teoria2;

A[] vector = new A[] { new C(1), new D(2), new B(3), new D(4), new B(5) };
foreach (A a in vector) {
    if (a.GetType().Equals(typeof(B))){
        a.Imprimir();
    }

    /*
    Type t = a.GetType();
    if (t.Equals(typeof(B))){
        a.Imprimir();
    }
    */
}

Console.ReadKey();