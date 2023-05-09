Taxi t = new Taxi(3);
Console.WriteLine($"Un {t.Marca} con {t.Pasajeros} pasajeros");
Console.ReadKey();

class Auto {
    public string Marca { get; private set; } = "Ford";
    public Auto(string marca) => this.Marca = marca;
}

class Taxi : Auto {
    public int Pasajeros { get; private set; }
    public Taxi(int pasajeros) : base("Honda") => this.Pasajeros = pasajeros;
}