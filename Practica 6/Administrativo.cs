namespace Teoria6;

class Administrativo : Empleado {
    public Administrativo(string nombre, int _DNI, DateTime fecha, double salario) : base(nombre, _DNI, fecha, salario) { }

    public double Premio { get; set;}

    public override double Salario {
        get {
            return SalarioBase + Premio;
        }
    }

    public override void AumentarSalario() {
        SalarioBase = SalarioBase + (SalarioBase * Antiguedad * 0.01);
    }

    public override string ToString()
    {
        return "Administrativo " + base.ToString() + ", Salario: " + Salario +
        "\n-------------";
    }
}