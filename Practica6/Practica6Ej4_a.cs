Taxi t = new Taxi(3);
Console.WriteLine($"Un {t.Marca} con {t.Pasajeros} pasajeros");
Console.ReadKey();

class Auto {
    public string Marca { get; private set; } = "Ford";
    public Auto(string marca) => this.Marca = marca;
    public Auto() { }       // #¿Que pasa si lo borro?
}

class Taxi : Auto {
    public int Pasajeros { get; private set; }
    public Taxi(int pasajeros) => this.Pasajeros = pasajeros;
}

/*
No hace falta agregar :base en el constructor de taxi porque la unica variable que se necesita inicializar es "Pasajeros". Esto indica que todos los objetos de que se creen de tipo taxi van a tener "Ford" como marca.

¿Hereda indirectamente el constructor vacio? #
*/