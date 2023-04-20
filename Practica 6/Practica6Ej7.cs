Imprimidor.Imprimir(new A(), new B(), new C(), new D());

Console.ReadKey();

abstract class Letra {
    public virtual void Imprimir() => Console.Write("Soy una instancia ");
}
class A : Letra {
    public override void Imprimir() {
        base.Imprimir();
        Console.WriteLine("A");
    }
}
class B : Letra {
    public override void Imprimir() {
        base.Imprimir();
        Console.WriteLine("B");
    }
}
class C : Letra {
    public override void Imprimir() {
        base.Imprimir();
        Console.WriteLine("C");
    }
}
class D : Letra {
    public override void Imprimir() {
        base.Imprimir();
        Console.WriteLine("D");
    }
}

static class Imprimidor {
    public static void Imprimir(params object[] vector) {
        foreach (Letra L in vector) {
            L.Imprimir();
        }
    }
}