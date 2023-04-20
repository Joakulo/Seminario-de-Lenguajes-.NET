namespace Teoria6;

class Vendedor : Empleado {
    public Vendedor(string nombre, int _DNI, DateTime fecha, double salario) : base(nombre, _DNI, fecha, salario) { }

    public double Comision { get; set;}

    public override double Salario {
        get {
            return SalarioBase + Comision;
        }
    }

    public override void AumentarSalario() {
        if (Antiguedad < 10) {
            SalarioBase += SalarioBase * 0.05;
        } else {
            SalarioBase += SalarioBase * 0.10;
        }
    }

    public override string ToString()
    {
        return "Vendedor " + base.ToString() + ", Salario: " + Salario +
        "\n-------------";
    }
}